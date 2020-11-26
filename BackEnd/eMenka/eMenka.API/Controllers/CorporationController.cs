using eMenka.API.Mappers;
using eMenka.API.Models.RecordModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Mappers.StaticMappers;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class CorporationController : GenericController<Corporation, CorporationModel, CorporationReturnModel>
    {
        private readonly ICompanyRepository _companyRepository;

        public CorporationController(ICorporationRepository corporationRepository, ICompanyRepository companyRepository) : base(corporationRepository, new CorporationMapper())
        {
            _companyRepository = companyRepository;
        }

        [HttpPost]
        public override IActionResult PostEntity([FromBody] CorporationModel corporationModel)
        {
            if (_companyRepository.GetById((int)corporationModel.CompanyId) == null)
                return NotFound($"Company with id {corporationModel.CompanyId} not found");

            return base.PostEntity(corporationModel);
        }

        public override IActionResult UpdateEntity(CorporationModel model, int id)
        {
            if (_companyRepository.GetById((int)model.CompanyId) == null)
                return NotFound($"Company with id {model.CompanyId} not found");

            return base.UpdateEntity(model, id);
        }
    }
}