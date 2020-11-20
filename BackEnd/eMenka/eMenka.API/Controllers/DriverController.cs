﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DriverController : ControllerBase
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IPersonRepository _personRepository;

        public DriverController(IDriverRepository driverRepository, IPersonRepository personRepository)
        {
            _driverRepository = driverRepository;
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult GetAllDrivers()
        {
            var drivers = _driverRepository.GetAll();

            return Ok(drivers.ToList().Select(FuelCardMappers.MapDriverEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetDriverById(int id)
        {
            var driver = _driverRepository.GetById(id);
            if (driver == null)
                return NotFound();

            return Ok(FuelCardMappers.MapDriverEntity(driver));
        }

        [HttpPost]
        public IActionResult PostDriver([FromBody] DriverModel driverModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (_personRepository.GetById((int)driverModel.PersonId) == null)
                return NotFound($"Person with id {driverModel.PersonId} not found");

            _driverRepository.Add(FuelCardMappers.MapDriverModel(driverModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDriver([FromBody] DriverModel driverModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (_personRepository.GetById((int)driverModel.PersonId) == null)
                return NotFound($"Person with id {driverModel.PersonId} not found");

            if (id != driverModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _driverRepository.Update(id, FuelCardMappers.MapDriverModel(driverModel));

            if (!isUpdated)
                return NotFound($"No Driver found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDriver(int id)
        {
            var driver = _driverRepository.GetById(id);
            if (driver == null)
                return NotFound();

            _driverRepository.Remove(driver);
            return Ok();
        }
    }
}
