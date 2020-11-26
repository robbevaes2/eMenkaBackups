using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Mappers.StaticMappers;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class FuelCardController : GenericController<FuelCard, FuelCardModel, FuelCardReturnModel>
    {
        private readonly IDriverRepository _driverRepository;

        public FuelCardController(IFuelCardRepository fuelCardRepository, IDriverRepository driverRepository) : base(fuelCardRepository, new FuelCardMapper())
        {
            _driverRepository = driverRepository;
        }

        public override IActionResult PostEntity(FuelCardModel model)
        {
            if (_driverRepository.GetById((int)model.DriverId) == null)
                return NotFound($"Driver with id {model.DriverId} not found");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(FuelCardModel model, int id)
        {
            if (_driverRepository.GetById((int)model.DriverId) == null)
                return NotFound($"Driver with id {model.DriverId} not found");

            return base.UpdateEntity(model, id);
        }
    }
}