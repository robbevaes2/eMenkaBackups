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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public IActionResult GetAllCompanies()
        {
            var companies = _companyRepository.GetAll();

            return Ok(companies.Select(RecordMappers.MapCompanyEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCompanyById(int id)
        {
            var company = _companyRepository.GetById(id);
            if (company == null)
                return NotFound();

            return Ok(RecordMappers.MapCompanyEntity(company));
        }

        [HttpPost]
        public IActionResult PostCompany([FromBody] CompanyModel companyModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            _companyRepository.Add(RecordMappers.MapCompanyModel(companyModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCompany([FromBody] CompanyModel companyModel, int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != companyModel.Id)
                return BadRequest("Id from model does not match query parameter id");

            var isUpdated = _companyRepository.Update(id, RecordMappers.MapCompanyModel(companyModel));

            if (!isUpdated)
                return NotFound($"No Company found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCompany(int id)
        {
            var company = _companyRepository.GetById(id);
            if (company == null)
                return NotFound();

            _companyRepository.Remove(company);
            return Ok();
        }
    }
}