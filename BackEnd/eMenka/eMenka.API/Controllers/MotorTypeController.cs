using System;
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
        private readonly IBrandRepository _brandRepository;

        public MotorTypeController(IMotorTypeRepository motorTypeRepository, IBrandRepository brandRepository)
        {
            _motorTypeRepository = motorTypeRepository;
            _brandRepository = brandRepository;
        }

        [HttpGet]
        public IActionResult GetAllMotorTypes()
        {
            var motorTypes = _motorTypeRepository.GetAll();

            return Ok(motorTypes.ToList().Select(VehicleMappers.MapMotorTypeEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetMotorTypesById(int id)
        {
            var motorType = _motorTypeRepository.GetById(id);
            if (motorType == null)
                return NotFound();

            return Ok(VehicleMappers.MapMotorTypeEntity(motorType));
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetMotorTypeByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var motorTypes = _motorTypeRepository.Find(motorType => motorType.Brand.Id == brandId);
            
            return Ok(motorTypes.ToList().Select(VehicleMappers.MapMotorTypeEntity).ToList());
        }

        [HttpGet("name/{motorTypeName}")]
        public IActionResult GetMotorTypeByName(string motorTypeName)
        {
            var motorTypes = _motorTypeRepository.Find(motorType => motorType.Name == motorTypeName);
            
            return Ok(motorTypes.ToList().Select(VehicleMappers.MapMotorTypeEntity).ToList());
        }

        [HttpPost]
        public IActionResult PostMotorType([FromBody] MotorTypeModel motorTypeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (_brandRepository.GetById((int)motorTypeModel.BrandId) == null)
                return NotFound($"No brand with id {motorTypeModel.BrandId}");

            _motorTypeRepository.Add(VehicleMappers.MapMotorTypeModel(motorTypeModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMotorType([FromBody] MotorTypeModel motorTypeModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != motorTypeModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            if (_brandRepository.GetById((int)motorTypeModel.BrandId) == null)
                return NotFound($"No brand with id {motorTypeModel.BrandId}");

            var isUpdated = _motorTypeRepository.Update(id, VehicleMappers.MapMotorTypeModel(motorTypeModel));

            if (!isUpdated)
                return NotFound($"No motortype found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMotorType(int id)
        {
            var motorType= _motorTypeRepository.GetById(id);
            if (motorType == null)
                return NotFound();

            _motorTypeRepository.Remove(motorType);
            return Ok();
        }
    }
}
