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
    public class CategoryController : GenericController<Category, CategoryModel, CategoryReturnModel>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper) : base(categoryRepository,
            mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet("name/{categoryName}")]
        public IActionResult GetCategoryByName(string categoryName)
        {
            var categories = _categoryRepository.Find(category => category.Name == categoryName);

            return Ok(categories.Select(_mapper.Map<CategoryReturnModel>).ToList());
        }
    }
}