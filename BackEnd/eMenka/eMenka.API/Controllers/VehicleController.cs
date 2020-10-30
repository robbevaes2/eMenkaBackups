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

            return Ok(vehicles.ToList().Select(MapVehicleEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicle = _vehicleRepository.GetById(id);
            if (vehicle == null)
                return BadRequest();

            return Ok(MapVehicleEntity(vehicle));
        }

        [HttpGet("{brand}")]
        public IActionResult GetVehicleByBrand(string brand)
        {
            var vehicles = _vehicleRepository.Find(vehicle=>vehicle.Brand.Name == brand);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(MapVehicleEntity));
        }

        [HttpGet("{model}")]
        public IActionResult GetVehicleByModel(string model)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.Model.Name == model);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(MapVehicleEntity));
        }

        [HttpGet("{isActive}")]
        public IActionResult GetVehicleByStatus(bool isActive)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.IsActive == isActive);
            if (vehicles == null)
                return BadRequest();
            
            return Ok(vehicles.ToList().Select(MapVehicleEntity));
        }

        [HttpPost]
        public IActionResult PostVehicle([FromBody] VehicleModel vehicleModel)
        {
            _vehicleRepository.Add(MapVehicleModel(vehicleModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVehicle([FromBody] VehicleModel vehicleModel, int id)
        {
            var isUpdated = _vehicleRepository.Update(id, MapVehicleModel(vehicleModel));

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

        public VehicleModel MapVehicleEntity(Vehicle vehicle)
        {
            return new VehicleModel
            {
                Id = vehicle.Id,
                BrandId = vehicle.Brand.Id,
                FuelType = vehicle.FuelType,
                MotorTypeId = vehicle.MotorType.Id,
                DoorTypeId = vehicle.DoorType.Id,
                Emission = vehicle.Emission,
                EndDate = vehicle.EndDate,
                FiscalePk = vehicle.FiscalePk,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                ModelId = vehicle.Id
            };
        }

        public Vehicle MapVehicleModel(VehicleModel vehicleModel)
        {
            return new Vehicle
            {
                Id = vehicleModel.Id,
                MotorTypeId = vehicleModel.MotorTypeId,
                BrandId = vehicleModel.BrandId,
                DoorTypeId = vehicleModel.DoorTypeId,
                Emission = vehicleModel.Emission,
                EndDate = vehicleModel.EndDate,
                FiscalePk = vehicleModel.FiscalePk,
                FuelType = vehicleModel.FuelType,
                IsActive = vehicleModel.IsActive,
                ModelId = vehicleModel.ModelId,
                Power = vehicleModel.Power,
                Volume = vehicleModel.Volume
            };
        }
    }
}
