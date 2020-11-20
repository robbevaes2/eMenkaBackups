using System.Linq;
using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyAllowSpecificOrigins")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IFuelTypeRepository _fuelTypeRepository;
        private readonly IEngineTypeRepository _engineTypeRepository;
        private readonly IDoorTypeRepository _doorTypeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public VehicleController(IVehicleRepository vehicleRepository, IBrandRepository brandRepository, IModelRepository modelRepository, IFuelTypeRepository fuelTypeRepository, IEngineTypeRepository engineTypeRepository, IDoorTypeRepository doorTypeRepository, ICategoryRepository categoryRepository)
        {
            _vehicleRepository = vehicleRepository;
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
            _fuelTypeRepository = fuelTypeRepository;
            _engineTypeRepository = engineTypeRepository;
            _doorTypeRepository = doorTypeRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            var vehicles = _vehicleRepository.GetAll();
            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return NotFound();

            return Ok(VehicleMappers.MapVehicleEntity(vehicle));
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetVehicleByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var vehicles = _vehicleRepository.Find(vehicle=>vehicle.BrandId == brandId);

            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity).ToList());
        }

        [HttpGet("brand/name/{brandName}")]
        public IActionResult GetVehiclesByBrandName(string brandName)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.Brand.Name == brandName);

            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity).ToList());
        }

        [HttpGet("model/{modelId}")]
        public IActionResult GetVehicleByModelId(int modelId)
        {
            if (_modelRepository.GetById(modelId) == null)
                return NotFound($"No model with id {modelId}");

            var vehicles = _vehicleRepository.Find(vehicle => vehicle.ModelId == modelId);

            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity).ToList());
        }

        [HttpGet("isActive/{isActive}")]
        public IActionResult GetVehicleByStatus(bool isActive)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.IsActive == isActive);
            
            return Ok(vehicles.ToList().Select(VehicleMappers.MapVehicleEntity).ToList());
        }

        [HttpPost]
        public IActionResult PostVehicle([FromBody] VehicleModel vehicleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (_brandRepository.GetById((int)vehicleModel.BrandId) == null)
                return NotFound($"No brand with id {vehicleModel.BrandId}");

            if (_modelRepository.GetById((int)vehicleModel.ModelId) == null)
                return NotFound($"No model with id {vehicleModel.ModelId}");

            if (_fuelTypeRepository.GetById((int)vehicleModel.FuelTypeId) == null)
                return NotFound($"No fuelType with id {vehicleModel.FuelTypeId}");

            if (_engineTypeRepository.GetById((int)vehicleModel.EngineTypeId) == null)
                return NotFound($"No motortype with id {vehicleModel.EngineTypeId}");

            if (_doorTypeRepository.GetById((int)vehicleModel.DoorTypeId) == null)
                return NotFound($"No doortype with id {vehicleModel.DoorTypeId}");

            if (_categoryRepository.GetById((int) vehicleModel.CategoryId) == null)
                return NotFound($"No category with id {vehicleModel.CategoryId}");

            _vehicleRepository.Add(VehicleMappers.MapVehicleModel(vehicleModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVehicle([FromBody] VehicleModel vehicleModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (id != vehicleModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            if (_brandRepository.GetById((int)vehicleModel.BrandId) == null)
                return NotFound($"No brand with id {vehicleModel.BrandId}");

            if (_modelRepository.GetById((int)vehicleModel.ModelId) == null)
                return NotFound($"No model with id {vehicleModel.ModelId}");

            if (_fuelTypeRepository.GetById((int)vehicleModel.FuelTypeId) == null)
                return NotFound($"No fuelType with id {vehicleModel.FuelTypeId}");

            if (_engineTypeRepository.GetById((int)vehicleModel.EngineTypeId) == null)
                return NotFound($"No motortype with id {vehicleModel.EngineTypeId}");

            if (_doorTypeRepository.GetById((int)vehicleModel.DoorTypeId) == null)
                return NotFound($"No doortype with id {vehicleModel.DoorTypeId}");

            if (_categoryRepository.GetById((int)vehicleModel.CategoryId) == null)
                return NotFound($"No category with id {vehicleModel.CategoryId}");

            var isUpdated = _vehicleRepository.Update(id, VehicleMappers.MapVehicleModel(vehicleModel));

            if (!isUpdated)
                return NotFound($"No vehicle found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return NotFound();

            _vehicleRepository.Remove(vehicle);
            return Ok();
        }

        public VehicleModel MapVehicleEntity(Vehicle vehicle)
        {
            return new VehicleModel
            {
                Id = vehicle.Id,
                BrandId = vehicle.Brand.Id,
                FuelTypeId = vehicle.FuelTypeId,
                EngineTypeId = vehicle.EngineType.Id,
                DoorTypeId = vehicle.DoorTypeId,
                Emission = vehicle.Emission,
                FiscalHP = vehicle.FiscalHP,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                ModelId = vehicle.Id,
                FuelCardId = vehicle.FuelCardId
            };
        }

        public Vehicle MapVehicleModel(VehicleModel vehicleModel)
        {
            return new Vehicle
            {
                Id = vehicleModel.Id,
                EngineTypeId = vehicleModel.EngineTypeId,
                BrandId = vehicleModel.BrandId,
                DoorTypeId = vehicleModel.DoorTypeId,
                Emission = vehicleModel.Emission,
                FiscalHP = vehicleModel.FiscalHP,
                FuelTypeId = vehicleModel.FuelTypeId,
                IsActive = vehicleModel.IsActive,
                ModelId = vehicleModel.ModelId,
                Power = vehicleModel.Power,
                Volume = vehicleModel.Volume,
                FuelCardId = vehicleModel.FuelCardId
            };
        }

    }
}
