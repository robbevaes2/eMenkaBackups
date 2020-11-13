﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class MotorTypeController : ControllerBase
    {
        private readonly IMotorTypeRepository _motorTypeRepository;

        public MotorTypeController(IMotorTypeRepository motorTypeRepository)
        {
            _motorTypeRepository = motorTypeRepository;
        }

        [HttpGet]
        public IActionResult GetAllMotorTypes()
        {
            var motorTypes = _motorTypeRepository.GetAll();
            if (motorTypes == null)
                return BadRequest();

            return Ok(motorTypes.ToList().Select(VehicleMappers.MapMotorTypeEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetMotorTypesById(int id)
        {
            var motorType = _motorTypeRepository.GetById(id);
            if (motorType == null)
                return BadRequest();

            return Ok(VehicleMappers.MapMotorTypeEntity(motorType));
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetMotorTypeByBrandId(int brandId)
        {
            var motorTypes = _motorTypeRepository.Find(motorType => motorType.Brand.Id == brandId);
            if (motorTypes == null)
                return BadRequest();

            return Ok(motorTypes.ToList().Select(VehicleMappers.MapMotorTypeEntity));
        }

        [HttpGet("name/{motorTypeName}")]
        public IActionResult GetMotorTypeByName(string motorTypeName)
        {
            var motorTypes = _motorTypeRepository.Find(motorType => motorType.Name == motorTypeName);
            if (motorTypes == null)
                return BadRequest();

            return Ok(motorTypes.ToList().Select(VehicleMappers.MapMotorTypeEntity));
        }

        [HttpPost]
        public IActionResult PostMotorType([FromBody] MotorTypeModel motorTypeModel)
        {
            _motorTypeRepository.Add(VehicleMappers.MapMotorTypeModel(motorTypeModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMotorType([FromBody] MotorTypeModel motorTypeModel, int id)
        {
            if(id != motorTypeModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _motorTypeRepository.Update(id, VehicleMappers.MapMotorTypeModel(motorTypeModel));

            if (!isUpdated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMotorType(int id)
        {
            var motorType= _motorTypeRepository.GetById(id);
            if (motorType == null)
                return BadRequest();

            _motorTypeRepository.Remove(motorType);
            return Ok();
        }
    }
}
