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
    public class ModelController : GenericController<Model, ModelModel, ModelReturnModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public ModelController(IModelRepository modelRepository, IBrandRepository brandRepository, IMapper mapper) : base(
            modelRepository, mapper)
        {
            _modelRepository = modelRepository;
            _brandRepository = brandRepository;
            _mapper = mapper;
        }


        [HttpGet("brand/{brandId}")]
        public IActionResult GetByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"Merk met id {brandId} niet gevonden");

            var models = _modelRepository.Find(model => model.Brand.Id == brandId);

            return Ok(models.Select(_mapper.Map<ModelReturnModel>).ToList());
        }

        public override IActionResult PostEntity(ModelModel model)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"Merk met id {model.BrandId} niet gevonden");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(ModelModel model, int id)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"Merk met id {model.BrandId} niet gevonden");

            return base.UpdateEntity(model, id);
        }
    }
}