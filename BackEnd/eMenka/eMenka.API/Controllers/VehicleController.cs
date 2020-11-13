using System.Linq;
using eMenka.API.Mappers;
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

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            var vehicles = _vehicleRepository.GetAll();
            if (vehicles == null)
                return BadRequest();

            return Ok(vehicles.ToList().Select(VehicleReturnMappers.MapVehicleEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return BadRequest();

            return Ok(VehicleReturnMappers.MapVehicleEntity(vehicle));
        }

        [HttpGet("{brandId}")]
        public IActionResult GetVehicleByBrandId(int brandId)
        {
            var vehicles = _vehicleRepository.Find(vehicle=>vehicle.BrandId == brandId);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(VehicleReturnMappers.MapVehicleEntity));
        }

        [HttpGet("{brandName}")]
        public IActionResult GetVehiclesByBrandName(string brandName)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.Brand.Name == brandName);
            if (vehicles == null)
                return BadRequest();

            return Ok(vehicles.ToList().Select(VehicleReturnMappers.MapVehicleEntity));
        }

        [HttpGet("{modelId}")]
        public IActionResult GetVehicleByModelId(int modelId)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.ModelId == modelId);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(VehicleReturnMappers.MapVehicleEntity));
        }

        [HttpGet("{isActive}")]
        public IActionResult GetVehicleByStatus(bool isActive)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.IsActive == isActive);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(VehicleReturnMappers.MapVehicleEntity));
        }

        [HttpPost]
        public IActionResult PostVehicle([FromBody] VehicleReturnModel vehicleReturnModel)
        {
            _vehicleRepository.Add(VehicleReturnMappers.MapVehicleModel(vehicleReturnModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVehicle([FromBody] VehicleReturnModel vehicleReturnModel, int id)
        {
            var isUpdated = _vehicleRepository.Update(id, VehicleReturnMappers.MapVehicleModel(vehicleReturnModel));

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
