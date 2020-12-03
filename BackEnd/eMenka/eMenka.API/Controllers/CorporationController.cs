using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class CorporationController : GenericController<Corporation, CorporationModel, CorporationReturnModel>
    {
        private readonly ICompanyRepository _companyRepository;

        public CorporationController(ICorporationRepository corporationRepository, ICompanyRepository companyRepository)
            : base(corporationRepository, new CorporationMapper())
        {
            _companyRepository = companyRepository;
        }

        [HttpPost]
        public override IActionResult PostEntity([FromBody] CorporationModel model)
        {
            if (_companyRepository.GetById((int)model.CompanyId) == null)
                return NotFound($"Company with id {model.CompanyId} not found");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(CorporationModel model, int id)
        {
            if (_companyRepository.GetById((int)model.CompanyId) == null)
                return NotFound($"Company with id {model.CompanyId} not found");

            return base.UpdateEntity(model, id);
        }
    }
}