using eMenka.API.Mappers;
using eMenka.API.Models.RecordModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.StaticMappers;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RecordController : ControllerBase
    {
        private readonly ICorporationRepository _corporationRepository;
        private readonly ICostAllocationRepository _costAllocationRepository;
        private readonly IFuelCardRepository _fuelCardRepository;
        private readonly IRecordRepository _recordRepository;

        public RecordController(IRecordRepository recordRepository, IFuelCardRepository fuelCardRepository,
            ICorporationRepository corporationRepository, ICostAllocationRepository costAllocationRepository)
        {
            _recordRepository = recordRepository;
            _fuelCardRepository = fuelCardRepository;
            _corporationRepository = corporationRepository;
            _costAllocationRepository = costAllocationRepository;
        }

        [HttpGet]
        public IActionResult GetAllRecords()
        {
            var records = _recordRepository.GetAll();

            return Ok(records.Select(RecordMappers.MapRecordEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetRecordById(int id)
        {
            var record = _recordRepository.GetById(id);
            if (record == null)
                return NotFound();

            return Ok(RecordMappers.MapRecordEntity(record));
        }

        [HttpPost]
        public IActionResult PostRecord([FromBody] RecordModel recordModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (_fuelCardRepository.GetById((int)recordModel.FuelCardId) == null)
                return NotFound($"Fuelcard with id {recordModel.FuelCardId} not found");

            if (_corporationRepository.GetById((int)recordModel.CorporationId) == null)
                return NotFound($"Corporation with id {recordModel.CorporationId} not found");

            if (_costAllocationRepository.GetById((int)recordModel.CostAllocationId) == null)
                return NotFound($"Cost allocation with id {recordModel.CostAllocationId} not found");

            if (_recordRepository.Find(r => r.FuelCard.Id == recordModel.FuelCardId).FirstOrDefault() != null)
                return BadRequest($"A record already exists with fuelcard id {recordModel.FuelCardId}");

            _recordRepository.Add(RecordMappers.MapRecordModel(recordModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRecord([FromBody] RecordModel recordModel, int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != recordModel.Id)
                return BadRequest("Id from model does not match query parameter id");

            if (_fuelCardRepository.GetById((int)recordModel.FuelCardId) == null)
                return NotFound($"Fuelcard with id {recordModel.FuelCardId} not found");

            if (_corporationRepository.GetById((int)recordModel.CorporationId) == null)
                return NotFound($"Corporation with id {recordModel.CorporationId} not found");

            if (_costAllocationRepository.GetById((int)recordModel.CostAllocationId) == null)
                return NotFound($"Cost allocation with id {recordModel.CostAllocationId} not found");

            if (_recordRepository.Find(r => r.FuelCard.Id == recordModel.FuelCardId).FirstOrDefault() != null)
                return BadRequest($"A record already exists with fuelcard id {recordModel.FuelCardId}");

            var isUpdated = _recordRepository.Update(id, RecordMappers.MapRecordModel(recordModel));

            if (!isUpdated)
                return NotFound($"No Record found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRecord(int id)
        {
            var record = _recordRepository.GetById(id);
            if (record == null)
                return NotFound();

            _recordRepository.Remove(record);
            return Ok();
        }
    }
}