using System.Linq;
using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class RecordController : GenericController<Record, RecordModel, RecordReturnModel>
    {
        private readonly ICorporationRepository _corporationRepository;
        private readonly ICostAllocationRepository _costAllocationRepository;
        private readonly IFuelCardRepository _fuelCardRepository;
        private readonly IRecordRepository _recordRepository;

        public RecordController(IRecordRepository recordRepository, IFuelCardRepository fuelCardRepository,
            ICorporationRepository corporationRepository, ICostAllocationRepository costAllocationRepository) : base(
            recordRepository, new RecordMapper())
        {
            _recordRepository = recordRepository;
            _fuelCardRepository = fuelCardRepository;
            _corporationRepository = corporationRepository;
            _costAllocationRepository = costAllocationRepository;
        }

        public override IActionResult PostEntity(RecordModel model)
        {
            if (_fuelCardRepository.GetById((int) model.FuelCardId) == null)
                return NotFound($"Fuelcard with id {model.FuelCardId} not found");

            if (_corporationRepository.GetById((int) model.CorporationId) == null)
                return NotFound($"Corporation with id {model.CorporationId} not found");

            if (_costAllocationRepository.GetById((int) model.CostAllocationId) == null)
                return NotFound($"Cost allocation with id {model.CostAllocationId} not found");

            if (_recordRepository.Find(r => r.FuelCard.Id == model.FuelCardId).FirstOrDefault() != null)
                return BadRequest($"A record already exists with fuelcard id {model.FuelCardId}");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(RecordModel model, int id)
        {
            if (_fuelCardRepository.GetById((int) model.FuelCardId) == null)
                return NotFound($"Fuelcard with id {model.FuelCardId} not found");

            if (_corporationRepository.GetById((int) model.CorporationId) == null)
                return NotFound($"Corporation with id {model.CorporationId} not found");

            if (_costAllocationRepository.GetById((int) model.CostAllocationId) == null)
                return NotFound($"Cost allocation with id {model.CostAllocationId} not found");

            var record = _recordRepository.Find(r => r.FuelCard.Id == model.FuelCardId).FirstOrDefault();

            if (record != null && record.Id != model.Id)
                return BadRequest($"A record already exists with fuelcard id {model.FuelCardId}");

            return base.UpdateEntity(model, id);
        }
    }
}