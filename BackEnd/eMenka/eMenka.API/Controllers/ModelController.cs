using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class ModelController : GenericController<Model, ModelModel, ModelReturnModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;

        public ModelController(IModelRepository modelRepository, IBrandRepository brandRepository) : base(modelRepository, new ModelMapper())
        {
            _modelRepository = modelRepository;
            _brandRepository = brandRepository;
        }

        
        [HttpGet("brand/{brandId}")]
        public IActionResult GetByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var models = _modelRepository.Find(model => model.Brand.Id == brandId);

            return Ok(models.Select(VehicleMappers.MapModelEntity).ToList());
        }

        public override IActionResult PostEntity(ModelModel model)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(ModelModel model, int id)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            return base.UpdateEntity(model, id);
        }
    }
}