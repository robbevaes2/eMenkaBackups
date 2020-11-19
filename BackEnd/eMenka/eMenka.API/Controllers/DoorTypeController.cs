﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;


namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DoorTypeController : ControllerBase
    {
        private readonly IDoorTypeRepository _doorTypeRepository;

        public DoorTypeController(IDoorTypeRepository doorTypeRepository)
        {
            _doorTypeRepository = doorTypeRepository;
        }


        [HttpGet]
        public IActionResult GetAllDoorTypes()
        {
            var doorTypes = _doorTypeRepository.GetAll();

            return Ok(doorTypes.ToList().Select(VehicleMappers.MapDoorTypeEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetDoorTypeById(int id)
        {
            var doorType = _doorTypeRepository.GetById(id);
            if (doorType == null)
                return NotFound();

            return Ok(VehicleMappers.MapDoorTypeEntity(doorType));
        }

        [HttpGet("name/{doorTypeName}")]
        public IActionResult GetDoorTypeByName(string doorTypeName)
        {
            var doorTypes = _doorTypeRepository.Find(doorType => doorType.Name == doorTypeName);

            return Ok(doorTypes.ToList().Select(VehicleMappers.MapDoorTypeEntity).ToList());
        }

        [HttpPost]
        public IActionResult PostDoorType([FromBody] DoorTypeModel doorTypeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _doorTypeRepository.Add(VehicleMappers.MapDoorTypeModel(doorTypeModel)); 
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoorType([FromBody] DoorTypeModel doorTypeModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != doorTypeModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _doorTypeRepository.Update(id, VehicleMappers.MapDoorTypeModel(doorTypeModel));

            if (!isUpdated)
                return NotFound($"No DoorType found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoorType(int id)
        {
            var doorType = _doorTypeRepository.GetById(id);
            if (doorType == null)
                return NotFound();

            _doorTypeRepository.Remove(doorType);
            return Ok();
        }
    }
}