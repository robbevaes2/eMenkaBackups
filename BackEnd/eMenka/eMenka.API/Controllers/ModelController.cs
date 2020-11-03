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
    public class ModelController : ControllerBase
    {
        private readonly IModelRepository _modelRepository;

        public ModelController(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        [HttpGet]
        public IActionResult GetAllModels()
        {
            var models = _modelRepository.GetAll();
            if (models == null)
                return BadRequest();

            return Ok(models.ToList().Select(MapModelEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetModelsById(int id)
        {
            var model = _modelRepository.GetById(id);
            if (model == null)
                return BadRequest();

            return Ok(MapModelEntity(model));
        }

        [HttpPost]
        public IActionResult PostModel([FromBody] ModelModel modelModel)
        {
            _modelRepository.Add(MapModelModel(modelModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateModel([FromBody] ModelModel modelModel, int id)
        {
            var isUpdated = _modelRepository.Update(id, MapModelModel(modelModel));

            if (!isUpdated)
                return BadRequest();

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

        private ModelModel MapModelEntity(Model model)
        {
            return new ModelModel
            {
                BrandId = model.BrandId,
                Name = model.Name,
                Id = model.Id
            };
        }
        private Model MapModelModel(ModelModel modelModel)
        {
            return new Model
            {
                BrandId = modelModel.BrandId,
                Id = modelModel.Id,
                Name = modelModel.Name
            };
        }
    }
}
