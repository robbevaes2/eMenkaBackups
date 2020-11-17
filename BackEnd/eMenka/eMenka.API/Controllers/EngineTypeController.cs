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
    public class EngineTypeController : ControllerBase
    {
        private readonly IEngineTypeRepository _engineTypeRepository;

        public EngineTypeController(IEngineTypeRepository engineTypeRepository)
        {
            _engineTypeRepository = engineTypeRepository;
        }

        [HttpGet]
        public IActionResult GetAllEngineTypes()
        {
            var engineTypes = _engineTypeRepository.GetAll();
            if (engineTypes == null)
                return BadRequest();

            return Ok(engineTypes.ToList().Select(MapEngineTypeEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetEngineTypesById(int id)
        {
            var engineType = _engineTypeRepository.GetById(id);
            if (engineType == null)
                return BadRequest();

            return Ok(MapEngineTypeEntity(engineType));
        }

        [HttpGet("{engineTypeName}")]
        public IActionResult GetEngineTypeByName(string engineTypeName)
        {
            var engineTypes = _engineTypeRepository.Find(engineType => engineType.Name == engineTypeName);
            if (engineTypes == null)
                return BadRequest();

            return Ok(engineTypes.ToList().Select(MapEngineTypeEntity));
        }

        [HttpPost]
        public IActionResult PostEngineType([FromBody] EngineTypeModel engineTypeModel)
        {
            _engineTypeRepository.Add(MapEngineTypeModel(engineTypeModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEngineType([FromBody] EngineTypeModel engineTypeModel, int id)
        {
            var isUpdated = _engineTypeRepository.Update(id, MapEngineTypeModel(engineTypeModel));

            if (!isUpdated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEngineType(int id)
        {
            var engineType= _engineTypeRepository.GetById(id);
            if (engineType == null)
                return BadRequest();

            _engineTypeRepository.Remove(engineType);
            return Ok();
        }

        private EngineTypeModel MapEngineTypeEntity(EngineType engineType)
        {
            return new EngineTypeModel
            {
                BrandId = engineType.BrandId,
                Name = engineType.Name,
                Id = engineType.Id
            };
        }
        private EngineType MapEngineTypeModel(EngineTypeModel engineTypeModel)
        {
            return new EngineType
            {
                BrandId = engineTypeModel.BrandId,
                Id = engineTypeModel.Id,
                Name = engineTypeModel.Name
            };
        }


    }
}
