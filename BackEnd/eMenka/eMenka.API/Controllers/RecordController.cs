using System;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutoMapper;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class RecordController : GenericController<Record, RecordModel, RecordReturnModel>
    {
        private readonly ICorporationRepository _corporationRepository;
        private readonly ICostAllocationRepository _costAllocationRepository;
        private readonly IFuelCardRepository _fuelCardRepository;
        private readonly IRecordRepository _recordRepository;
        private readonly IMapper _mapper;


        public RecordController(IRecordRepository recordRepository, IFuelCardRepository fuelCardRepository,
            ICorporationRepository corporationRepository, ICostAllocationRepository costAllocationRepository, IMapper mapper) : base(
            recordRepository, mapper)
        {
            _recordRepository = recordRepository;
            _fuelCardRepository = fuelCardRepository;
            _corporationRepository = corporationRepository;
            _costAllocationRepository = costAllocationRepository;
            _mapper = mapper;
        }

        [HttpGet("enddate/{range}")]
        public IActionResult GetRecordByEndDate(int range)
        {
            var records = _recordRepository.Find(v => v.EndDate >= DateTime.Now.Date && v.EndDate <= DateTime.Now.Date.AddDays(range));

            return Ok(records.Select(_mapper.Map<RecordReturnModel>).ToList());
        }

        public override IActionResult PostEntity(RecordModel model)
        {
            if (_fuelCardRepository.GetById((int)model.FuelCardId) == null)
                return NotFound($"Tankkaart met id {model.FuelCardId} niet gevonden");

            if (_corporationRepository.GetById((int)model.CorporationId) == null)
                return NotFound($"Vennootschap met id {model.CorporationId} niet gevonden");

            if (_costAllocationRepository.GetById((int)model.CostAllocationId) == null)
                return NotFound($"Kosten allocatie met id {model.CostAllocationId} niet gevonden");

            if (_recordRepository.Find(r => r.FuelCard.Id == model.FuelCardId).FirstOrDefault() != null)
                return BadRequest($"Een dossier met tankkaart id {model.FuelCardId} bestaat al");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(RecordModel model, int id)
        {
            if (_fuelCardRepository.GetById((int)model.FuelCardId) == null)
                return NotFound($"Tankkaart met id {model.FuelCardId} niet gevonden");

            if (_corporationRepository.GetById((int)model.CorporationId) == null)
                return NotFound($"Vennootschap met id {model.CorporationId} niet gevonden");

            if (_costAllocationRepository.GetById((int)model.CostAllocationId) == null)
                return NotFound($"Kosten allocatie met id {model.CostAllocationId} niet gevonden");

            var record = _recordRepository.Find(r => r.FuelCard.Id == model.FuelCardId).FirstOrDefault();

            if (record != null && record.Id != model.Id)
                return BadRequest($"Een dossier met tankkaart id {model.FuelCardId} bestaat al");

            return base.UpdateEntity(model, id);
        }
    }
}