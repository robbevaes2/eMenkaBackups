using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class FuelTypeController : GenericController<FuelType, FuelTypeModel, FuelTypeReturnModel>
    {

        public FuelTypeController(IFuelTypeRepository fuelTypeRepository) : base(fuelTypeRepository, new FuelTypeMapper()) 
        {
        }
    }
}