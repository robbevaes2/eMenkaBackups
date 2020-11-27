using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : GenericController<Category, CategoryModel, CategoryReturnModel>
    {
        private readonly ICategoryRepository _categoryRepository;
        private CategoryMapper _categoryMapper;

        public CategoryController(ICategoryRepository categoryRepository) : base(categoryRepository, new CategoryMapper())
        {
            _categoryRepository = categoryRepository;
            _categoryMapper = new CategoryMapper();
        }

        [HttpGet("name/{categoryName}")]
        public IActionResult GetCategoryByName(string categoryName)
        {
            var categories = _categoryRepository.Find(category => category.Name == categoryName);

            return Ok(categories.Select(_categoryMapper.MapEntityToReturnModel).ToList());
        }
    }
}