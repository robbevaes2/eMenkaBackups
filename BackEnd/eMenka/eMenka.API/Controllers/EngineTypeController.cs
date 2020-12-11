using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutoMapper;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class EngineTypeController : GenericController<EngineType, EngineTypeModel, EngineTypeReturnModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IEngineTypeRepository _engineTypeRepository;
        private readonly IMapper _mapper;

        public EngineTypeController(IEngineTypeRepository engineTypeRepository, IBrandRepository brandRepository, IMapper mapper) :
            base(engineTypeRepository, mapper)
        {
            _engineTypeRepository = engineTypeRepository;
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetEngineTypesByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"Merk met id {brandId} niet gevonden");

            var engineTypes = _engineTypeRepository.Find(motorType => motorType.Brand.Id == brandId).ToList();

            return Ok(engineTypes.Select(_mapper.Map<EngineTypeReturnModel>).ToList());
        }

        [HttpGet("{engineTypeName}")]
        public IActionResult GetEngineTypeByName(string engineTypeName)
        {
            var engineTypes = _engineTypeRepository.Find(engineType => engineType.Name == engineTypeName).ToList();

            return Ok(engineTypes.Select(_mapper.Map<EngineTypeReturnModel>).ToList());
        }

        public override IActionResult PostEntity(EngineTypeModel model)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"Merk met id {model.BrandId} niet gevonden");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(EngineTypeModel model, int id)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"Merk met id {model.BrandId} niet gevonden");

            return base.UpdateEntity(model, id);
        }
    }
}