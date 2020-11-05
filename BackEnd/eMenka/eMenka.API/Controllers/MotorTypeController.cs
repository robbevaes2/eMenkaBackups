using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.VehicleModels;
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

        [HttpGet("{motorTypeName}")]
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
