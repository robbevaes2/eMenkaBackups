using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers.VehicleMappers;
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
        public CountryController(ICountryRepository countryRepository) : base(countryRepository, new CountryMapper())
        {
        }
    }
}
