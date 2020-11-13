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
    public class ModelController : ControllerBase
    {
        private readonly IModelRepository _modelRepository;
        private readonly IBrandRepository _brandRepository;

        public ModelController(IModelRepository modelRepository, IBrandRepository brandRepository)
        {
            _modelRepository = modelRepository;
            _brandRepository = brandRepository;
        }

        [HttpGet]
        public IActionResult GetAllModels()
        {
            var models = _modelRepository.GetAll();
            if (models == null)
                return BadRequest();

            return Ok(models.ToList().Select(VehicleMappers.MapModelEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetModelsById(int id)
        {
            var model = _modelRepository.GetById(id);
            if (model == null)
                return BadRequest();

            return Ok(VehicleMappers.MapModelEntity(model));
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return BadRequest($"No brand with id {brandId}");

            var models = _modelRepository.Find(model => model.Brand.Id == brandId);

            if (models == null)
                return BadRequest();

            return Ok(models.ToList().Select(VehicleMappers.MapModelEntity));
        }

        [HttpPost]
        public IActionResult PostModel([FromBody] ModelModel modelModel)
        {
            if (_brandRepository.GetById((int)modelModel.BrandId) == null)
                return BadRequest($"No brand with id {modelModel.BrandId}");

            _modelRepository.Add(VehicleMappers.MapModelModel(modelModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateModel([FromBody] ModelModel modelModel, int id)
        {
            if(id != modelModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            if (_brandRepository.GetById((int)modelModel.BrandId) == null)
                return BadRequest($"No brand with id {modelModel.BrandId}");

            var isUpdated = _modelRepository.Update(id, VehicleMappers.MapModelModel(modelModel));

            if (!isUpdated)
                return BadRequest("Update failed");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteModel(int id)
        {
            var model = _modelRepository.GetById(id);
            if (model == null)
                return BadRequest();

            _modelRepository.Remove(model);
            return Ok();
        }
    }
}
