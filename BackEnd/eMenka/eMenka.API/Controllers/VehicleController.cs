using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.VehicleModels;
using eMenka.API.VehicleModels.ReturnModels;
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

        public VehicleModel MapVehicleObject(Vehicle vehicle)
        {
            var brand = new BrandModel
            {
                Name = vehicle.Brand.Name,
                Id = vehicle.Brand.Id
            };
            return new VehicleModel
            {
                Id = vehicle.Id,
                Brand = brand,
                FuelType = vehicle.FuelType,
                MotorType = new MotorTypeModel
                {
                    Id = vehicle.MotorType.Id,
                    Name = vehicle.MotorType.Name,
                    Brand = brand
                },
                DoorType = new DoorTypeModel
                {
                    Id = vehicle.DoorType.Id,
                    Name = vehicle.DoorType.Name
                },
                Emission = vehicle.Emission,
                EndDate = vehicle.EndDate,
                FiscalePk = vehicle.FiscalePk,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                Model = new ModelModel
                {
                    Id = vehicle.Model.Id,
                    Name = vehicle.Model.Name,
                    Brand = brand
                }
            };
        }

        public Vehicle MapVehicleModel(VehicleModel vehicleModel)
        {
            var brand = new Brand
            {
                Id = vehicleModel.Brand.Id,
                Name = vehicleModel.Brand.Name
            };

            return new Vehicle
            {
                Id = vehicleModel.Id,
                MotorType = new MotorType
                {
                    Id = vehicleModel.MotorType.Id,
                    Brand = brand,
                    Name = vehicleModel.MotorType.Name
                },
                Brand = brand,
                DoorType = new DoorType
                {
                    Id = vehicleModel.DoorType.Id,
                    Name = vehicleModel.DoorType.Name
                },
                Emission = vehicleModel.Emission,
                EndDate = vehicleModel.EndDate,
                FiscalePk = vehicleModel.FiscalePk,
                FuelType = vehicleModel.FuelType,
                IsActive = vehicleModel.IsActive,
                Model = new Model
                {
                    Id = vehicleModel.Model.Id,
                    Brand = brand,
                    Name = vehicleModel.Model.Name
                },
                Power = vehicleModel.Power,
                Volume = vehicleModel.Volume
            };
        }
    }
}
