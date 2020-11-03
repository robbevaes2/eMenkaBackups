using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            return Ok(motorTypes.ToList().Select(MapMotorTypeEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetMotorTypesById(int id)
        {
            var motorType = _motorTypeRepository.GetById(id);
            if (motorType == null)
                return BadRequest();

            return Ok(MapMotorTypeEntity(motorType));
        }

        [HttpGet("{motorTypeName}")]
        public IActionResult GetMotorTypeByName(string motorTypeName)
        {
            var motorTypes = _motorTypeRepository.Find(motorType => motorType.Name == motorTypeName);
            if (motorTypes == null)
                return BadRequest();

            return Ok(motorTypes.ToList().Select(MapMotorTypeEntity));
        }

        [HttpPost]
        public IActionResult PostMotorType([FromBody] MotorTypeModel motorTypeModel)
        {
            _motorTypeRepository.Add(MapMotorTypeModel(motorTypeModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMotorType([FromBody] MotorTypeModel motorTypeModel, int id)
        {
            var isUpdated = _motorTypeRepository.Update(id, MapMotorTypeModel(motorTypeModel));

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

        private MotorTypeModel MapMotorTypeEntity(MotorType motorType)
        {
            return new MotorTypeModel
            {
                BrandId = motorType.BrandId,
                Name = motorType.Name,
                Id = motorType.Id
            };
        }
        private MotorType MapMotorTypeModel(MotorTypeModel motorTypeModel)
        {
            return new MotorType
            {
                BrandId = motorTypeModel.BrandId,
                Id = motorTypeModel.Id,
                Name = motorTypeModel.Name
            };
        }


    }
}
