using AutoMapper;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : GenericController<Country, CountryModel, CountryReturnModel>
    {
        public CountryController(ICountryRepository countryRepository, IMapper mapper) : base(countryRepository, mapper)
        {
        }
    }
}