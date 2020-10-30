using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
            var vehicles = _vehicleRepository.Find(vehicle=>vehicle.Brand.Name == brand);
            //todo map model
            return Ok(vehicles.ToList());
        }
    }
}
