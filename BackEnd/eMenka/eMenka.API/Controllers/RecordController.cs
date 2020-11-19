using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.VehicleModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class RecordController : ControllerBase
    {
        private readonly IRecordRepository _recordRepository;
        private readonly ICompanyRepository _companyRepository;

        public RecordController(IRecordRepository recordRepository, ICompanyRepository companyRepository)
        {
            _recordRepository = recordRepository;
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public IActionResult GetAllRecords()
        {
            var records = _recordRepository.GetAll();

            return Ok(records.ToList().Select(RecordMappers.MapRecordEntity).ToList());
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
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _recordRepository.Add(RecordMappers.MapRecordModel(recordModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRecord([FromBody] RecordModel recordModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != recordModel.Id)
                return BadRequest("Id from model does not match query paramater id");

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
