using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.VehicleModels;
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

            return Ok(vehicles.ToList().Select(MapVehicleObject));
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return BadRequest();

            return Ok(MapVehicleObject(vehicle));
        }

        [HttpGet("{brand}")]
        public IActionResult GetVehicleByBrand(string brand)
        {
            var vehicles = _vehicleRepository.Find(vehicle=>vehicle.Brand.Name == brand);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(MapVehicleObject));
        }

        [HttpGet("{model}")]
        public IActionResult GetVehicleByModel(string model)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.Model.Name == model);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(MapVehicleObject));
        }

        [HttpGet("{isActive}")]
        public IActionResult GetVehicleByStatus(bool isActive)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.IsActive == isActive);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(MapVehicleObject));
        }

        public VehicleReturnModel MapVehicleObject(Vehicle vehicle)
        {
            var brand = new BrandReturnModel
            {
                Name = vehicle.Brand.Name
            };
            return new VehicleReturnModel
            {
                Brand = brand,
                FuelType = vehicle.FuelType,
                MotorType = new MotorTypeReturnModel
                {
                    Name = vehicle.MotorType.Name,
                    Brand = brand
                },
                DoorType = new DoorTypeReturnModel
                {
                    Name = vehicle.DoorType.Name
                },
                Emission = vehicle.Emission,
                EndDate = vehicle.EndDate,
                FiscalePk = vehicle.FiscalePk,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                Model = new ModelReturnModel
                {
                    Name = vehicle.Model.Name,
                    Brand = brand
                }
            };
        }
    }
}
