using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

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