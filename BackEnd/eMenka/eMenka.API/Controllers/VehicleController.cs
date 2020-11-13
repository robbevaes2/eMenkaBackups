using System.Linq;
using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IFuelTypeRepository _fuelTypeRepository;
        private readonly IMotorTypeRepository _motorTypeRepository;
        private readonly IDoorTypeRepository _doorTypeRepository;

        public VehicleController(IVehicleRepository vehicleRepository, IBrandRepository brandRepository, IModelRepository modelRepository, IFuelTypeRepository fuelTypeRepository, IMotorTypeRepository motorTypeRepository, IDoorTypeRepository doorTypeRepository)
        {
            _vehicleRepository = vehicleRepository;
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
            _fuelTypeRepository = fuelTypeRepository;
            _motorTypeRepository = motorTypeRepository;
            _doorTypeRepository = doorTypeRepository;
        }

        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            var vehicles = _vehicleRepository.GetAll();
            if (vehicles == null)
                return BadRequest();

            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return BadRequest();

            return Ok(VehicleMappers.MapVehicleEntity(vehicle));
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetVehicleByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return BadRequest($"No brand with id {brandId}");

            var vehicles = _vehicleRepository.Find(vehicle=>vehicle.BrandId == brandId);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity));
        }

        [HttpGet("brand/name/{brandName}")]
        public IActionResult GetVehiclesByBrandName(string brandName)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.Brand.Name == brandName);
            if (vehicles == null)
                return BadRequest();

            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity));
        }

        [HttpGet("model/{modelId}")]
        public IActionResult GetVehicleByModelId(int modelId)
        {
            if (_modelRepository.GetById(modelId) == null)
                return BadRequest($"No model with id {modelId}");

            var vehicles = _vehicleRepository.Find(vehicle => vehicle.ModelId == modelId);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity));
        }

        [HttpGet("isActive/{isActive}")]
        public IActionResult GetVehicleByStatus(bool isActive)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.IsActive == isActive);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity));
        }

        [HttpPost]
        public IActionResult PostVehicle([FromBody] VehicleModel vehicleModel)
        {
            if (_brandRepository.GetById((int)vehicleModel.BrandId) == null)
                return BadRequest($"No brand with id {vehicleModel.BrandId}");

            if (_modelRepository.GetById((int)vehicleModel.ModelId) == null)
                return BadRequest($"No model with id {vehicleModel.ModelId}");

            if (_fuelTypeRepository.GetById((int)vehicleModel.FuelTypeId) == null)
                return BadRequest($"No fuelType with id {vehicleModel.FuelTypeId}");

            if (_motorTypeRepository.GetById((int)vehicleModel.MotorTypeId) == null)
                return BadRequest($"No motortype with id {vehicleModel.MotorTypeId}");

            if (_doorTypeRepository.GetById((int)vehicleModel.DoorTypeId) == null)
                return BadRequest($"No doortype with id {vehicleModel.DoorTypeId}");

            _vehicleRepository.Add(VehicleMappers.MapVehicleModel(vehicleModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVehicle([FromBody] VehicleModel vehicleModel, int id)
        {
            if(id != vehicleModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            if (_brandRepository.GetById((int)vehicleModel.BrandId) == null)
                return BadRequest($"No brand with id {vehicleModel.BrandId}");

            if (_modelRepository.GetById((int)vehicleModel.ModelId) == null)
                return BadRequest($"No model with id {vehicleModel.ModelId}");

            if (_fuelTypeRepository.GetById((int)vehicleModel.FuelTypeId) == null)
                return BadRequest($"No fuelType with id {vehicleModel.FuelTypeId}");

            if (_motorTypeRepository.GetById((int)vehicleModel.MotorTypeId) == null)
                return BadRequest($"No motortype with id {vehicleModel.MotorTypeId}");

            if (_doorTypeRepository.GetById((int)vehicleModel.DoorTypeId) == null)
                return BadRequest($"No doortype with id {vehicleModel.DoorTypeId}");

            var isUpdated = _vehicleRepository.Update(id, VehicleMappers.MapVehicleModel(vehicleModel));

            if (!isUpdated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return BadRequest();

            _vehicleRepository.Remove(vehicle);
            return Ok();
        }
    }
}
