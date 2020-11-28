using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class FuelCardController : GenericController<FuelCard, FuelCardModel, FuelCardReturnModel>
    {
        private readonly IFuelCardRepository _fuelCardRepository;
        private readonly IDriverRepository _driverRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private FuelCardMapper _fuelCardMapper;

        public FuelCardController(IFuelCardRepository fuelCardRepository, IDriverRepository driverRepository, IVehicleRepository vehicleRepository) : base(fuelCardRepository, new FuelCardMapper())
        {
            _fuelCardRepository = fuelCardRepository;
            _driverRepository = driverRepository;
            _vehicleRepository = vehicleRepository;
            _fuelCardMapper = new FuelCardMapper();
        }

        public override IActionResult PostEntity(FuelCardModel model)
        {
            if (_driverRepository.GetById((int)model.DriverId) == null)
                return NotFound($"Driver with id {model.DriverId} not found");

            var vehicle = _vehicleRepository.GetById((int) model.VehicleId);

            if (vehicle == null)
                return NotFound($"Vehicles with id {model.VehicleId} not found");

            if (!ModelState.IsValid) return BadRequest();

            var entity = _fuelCardMapper.MapModelToEntity(model);

            _fuelCardRepository.Add(entity);

            vehicle.FuelCard = entity;
            _vehicleRepository.Update(vehicle.Id, vehicle);

            return Ok(_fuelCardMapper.MapEntityToReturnModel(entity));
        }

        public override IActionResult UpdateEntity(FuelCardModel model, int id)
        {
            if (_driverRepository.GetById((int)model.DriverId) == null)
                return NotFound($"Driver with id {model.DriverId} not found");

            if (_vehicleRepository.GetById((int)model.VehicleId) == null)
                return NotFound($"Vehicles with id {model.VehicleId} not found");

            return base.UpdateEntity(model, id);
        }
    }
}