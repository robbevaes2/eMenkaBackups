using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

            //todo map model
            return Ok(vehicles.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return BadRequest();

            //todo map model
            return Ok(vehicle);
        }

        [HttpGet("{brand}")]
        public IActionResult GetVehicleByBrand(string brand)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.Brand.Name == brand);
            //todo map model
            return Ok(vehicles.ToList());
        }
    }
}
