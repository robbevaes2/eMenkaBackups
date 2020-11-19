using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.Models.RecordModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CorporationController : ControllerBase
    {
        private readonly ICorporationRepository _corporationRepository;
        private readonly ICompanyRepository _companyRepository;

        public CorporationController(ICorporationRepository corporationRepository, ICompanyRepository companyRepository)
        {
            _corporationRepository = corporationRepository;
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public IActionResult GetAllCorporations()
        {
            var corporations = _corporationRepository.GetAll();

            return Ok(corporations.ToList().Select(RecordMappers.MapCorporationEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCorporationById(int id)
        {
            var corporation = _corporationRepository.GetById(id);
            if (corporation == null)
                return NotFound();

            return Ok(RecordMappers.MapCorporationEntity(corporation));
        }

        [HttpPost]
        public IActionResult PostCorporation([FromBody] CorporationModel corporationModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (_companyRepository.GetById((int)corporationModel.CompanyId) == null)
                return NotFound($"Company with id {corporationModel.CompanyId} not found");

            _corporationRepository.Add(RecordMappers.MapCorporationModel(corporationModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCorporation([FromBody] CorporationModel corporationModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != corporationModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            if (_companyRepository.GetById((int)corporationModel.CompanyId) == null)
                return NotFound($"Company with id {corporationModel.CompanyId} not found");

            var isUpdated = _corporationRepository.Update(id, RecordMappers.MapCorporationModel(corporationModel));

            if (!isUpdated)
                return NotFound($"No Corporation found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCorporation(int id)
        {
            var corporation = _corporationRepository.GetById(id);
            if (corporation == null)
                return NotFound();

            _corporationRepository.Remove(corporation);
            return Ok();
        }
    }
}
