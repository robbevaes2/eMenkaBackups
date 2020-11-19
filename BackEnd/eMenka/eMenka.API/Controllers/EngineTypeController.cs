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
    public class EngineTypeController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IEngineTypeRepository _engineTypeRepository;

        public EngineTypeController(IEngineTypeRepository engineTypeRepository, IBrandRepository brandRepository)
        {
            _engineTypeRepository = engineTypeRepository;
            _brandRepository = brandRepository;
        }

        [HttpGet]
        public IActionResult GetAllEngineTypes()
        {
            var engineTypes = _engineTypeRepository.GetAll();

            return Ok(engineTypes.ToList().Select(VehicleMappers.MapEngineTypeEntity).ToList());
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetEngineTypesByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var engineTypes = _engineTypeRepository.Find(motorType => motorType.Brand.Id == brandId);
            
            return Ok(engineTypes.ToList().Select(VehicleMappers.MapEngineTypeEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetEngineTypesById(int id)
        {
            var engineType = _engineTypeRepository.GetById(id);
            if (engineType == null)
                return NotFound();

            return Ok(VehicleMappers.MapEngineTypeEntity(engineType)); 
        }

        [HttpGet("{engineTypeName}")]
        public IActionResult GetEngineTypeByName(string engineTypeName)
        {
            var engineTypes = _engineTypeRepository.Find(engineType => engineType.Name == engineTypeName);

            return Ok(engineTypes.ToList().Select(VehicleMappers.MapEngineTypeEntity).ToList()); 
        }

        [HttpPost]
        public IActionResult PostEngineType([FromBody] EngineTypeModel engineTypeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (_brandRepository.GetById((int)engineTypeModel.BrandId) == null)
                return NotFound($"No brand with id {engineTypeModel.BrandId}");

            _engineTypeRepository.Add(VehicleMappers.MapEngineTypeModel(engineTypeModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEngineType([FromBody] EngineTypeModel engineTypeModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != engineTypeModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            if (_brandRepository.GetById((int)engineTypeModel.BrandId) == null)
                return NotFound($"No brand with id {engineTypeModel.BrandId}");

            var isUpdated = _engineTypeRepository.Update(id, VehicleMappers.MapEngineTypeModel(engineTypeModel));

            if (!isUpdated)
                return NotFound($"No motortype found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEngineType(int id)
        {
            var engineType= _engineTypeRepository.GetById(id);
            if (engineType == null)
                return NotFound();

            _engineTypeRepository.Remove(engineType);
            return Ok();
        }
    }
}
