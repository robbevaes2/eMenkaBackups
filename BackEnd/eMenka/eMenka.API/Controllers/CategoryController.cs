using System.Linq;
using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = _categoryRepository.GetAll();

            return Ok(categories.Select(VehicleMappers.MapCategoryEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _categoryRepository.GetById(id);
            if (category == null)
                return NotFound();

            return Ok(VehicleMappers.MapCategoryEntity(category));
        }

        [HttpGet("name/{categoryName}")]
        public IActionResult GetCategoryByName(string categoryName)
        {
            var categories = _categoryRepository.Find(category => category.Name == categoryName);

            return Ok(categories.Select(VehicleMappers.MapCategoryEntity).ToList());
        }

        [HttpPost]
        public IActionResult PostCategroy([FromBody] CategoryModel categoryModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            _categoryRepository.Add(VehicleMappers.MapCategoryModel(categoryModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory([FromBody] CategoryModel categoryModel, int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != categoryModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _categoryRepository.Update(id, VehicleMappers.MapCategoryModel(categoryModel));

            if (!isUpdated)
                return NotFound($"No Category found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _categoryRepository.GetById(id);
            if (category == null)
                return NotFound();

            _categoryRepository.Remove(category);
            return Ok();
        }
    }
}