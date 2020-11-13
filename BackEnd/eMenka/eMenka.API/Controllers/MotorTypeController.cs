using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
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

            return Ok(motorTypes.ToList().Select(VehicleReturnMappers.MapMotorTypeEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetMotorTypesById(int id)
        {
            var motorType = _motorTypeRepository.GetById(id);
            if (motorType == null)
                return BadRequest();

            return Ok(VehicleReturnMappers.MapMotorTypeEntity(motorType));
        }

        [HttpGet("{brandId}")]
        public IActionResult GetMotorTypeByBrandId(int brandId)
        {
            var motorTypes = _motorTypeRepository.Find(motorType => motorType.Brand.Id == brandId);
            if (motorTypes == null)
                return BadRequest();

            return Ok(motorTypes.ToList().Select(VehicleReturnMappers.MapMotorTypeEntity));
        }

        [HttpGet("{motorTypeName}")]
        public IActionResult GetMotorTypeByName(string motorTypeName)
        {
            var motorTypes = _motorTypeRepository.Find(motorType => motorType.Name == motorTypeName);
            if (motorTypes == null)
                return BadRequest();

            return Ok(motorTypes.ToList().Select(VehicleReturnMappers.MapMotorTypeEntity));
        }

        [HttpPost]
        public IActionResult PostMotorType([FromBody] MotorTypeReturnModel motorTypeReturnModel)
        {
            _motorTypeRepository.Add(VehicleReturnMappers.MapMotorTypeModel(motorTypeReturnModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMotorType([FromBody] MotorTypeReturnModel motorTypeReturnModel, int id)
        {
            var isUpdated = _motorTypeRepository.Update(id, VehicleReturnMappers.MapMotorTypeModel(motorTypeReturnModel));

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
