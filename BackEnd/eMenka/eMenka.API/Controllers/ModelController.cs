using System.Linq;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class ModelController : GenericController<Model, ModelModel, ModelReturnModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly ModelMapper _modelMapper;
        private readonly IModelRepository _modelRepository;

        public ModelController(IModelRepository modelRepository, IBrandRepository brandRepository) : base(
            modelRepository, new ModelMapper())
        {
            _modelRepository = modelRepository;
            _brandRepository = brandRepository;
            _modelMapper = new ModelMapper();
        }


        [HttpGet("brand/{brandId}")]
        public IActionResult GetByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var models = _modelRepository.Find(model => model.Brand.Id == brandId);

            return Ok(models.Select(_modelMapper.MapEntityToReturnModel).ToList());
        }

        public override IActionResult PostEntity(ModelModel model)
        {
            if (_brandRepository.GetById((int) model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(ModelModel model, int id)
        {
            if (_brandRepository.GetById((int) model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            return base.UpdateEntity(model, id);
        }
    }
}