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
    public class CompanyController : GenericController<Company, CompanyModel, CompanyReturnModel>
    {
        public CompanyController(ICompanyRepository companyRepository) : base(companyRepository, new CompanyMapper())
        {
        }
    }
}