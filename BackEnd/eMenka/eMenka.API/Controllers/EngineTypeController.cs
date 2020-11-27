using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class EngineTypeController : GenericController<EngineType, EngineTypeModel, EngineTypeReturnModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IEngineTypeRepository _engineTypeRepository;
        private EngineTypeMapper _engineTypeMapper;

        public EngineTypeController(IEngineTypeRepository engineTypeRepository, IBrandRepository brandRepository) : base(engineTypeRepository, new EngineTypeMapper())
        {
            _engineTypeRepository = engineTypeRepository;
            _brandRepository = brandRepository;
            _engineTypeMapper = new EngineTypeMapper();
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetEngineTypesByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var engineTypes = _engineTypeRepository.Find(motorType => motorType.Brand.Id == brandId);

            return Ok(engineTypes.Select(_engineTypeMapper.MapEntityToReturnModel).ToList());
        }

        [HttpGet("{engineTypeName}")]
        public IActionResult GetEngineTypeByName(string engineTypeName)
        {
            var engineTypes = _engineTypeRepository.Find(engineType => engineType.Name == engineTypeName);

            return Ok(engineTypes.Select(_engineTypeMapper.MapEntityToReturnModel).ToList());
        }

        public override IActionResult PostEntity(EngineTypeModel model)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(EngineTypeModel model, int id)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            return base.UpdateEntity(model, id);
        }
    }
}