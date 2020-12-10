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
    public class BrandController : GenericController<Brand, BrandModel, BrandReturnModel>
    {
        private readonly BrandMapper _brandMapper;
        private readonly IBrandRepository _brandRepository;
        private readonly IExteriorColorRepository _exteriorColorRepository;
        private readonly IInteriorColorRepository _interiorColorRepository;

        public BrandController(IBrandRepository brandRepository, IExteriorColorRepository exteriorColorRepository,
            IInteriorColorRepository interiorColorRepository) : base(brandRepository, new BrandMapper())
        {
            _brandRepository = brandRepository;
            _exteriorColorRepository = exteriorColorRepository;
            _interiorColorRepository = interiorColorRepository;
            _brandMapper = new BrandMapper();
        }

        [HttpGet("name/{brandName}")]
        public IActionResult GetBrandsByName(string brandName)
        {
            var brands = _brandRepository.Find(brand => brand.Name == brandName);

            return Ok(brands.Select(_brandMapper.MapEntityToReturnModel).ToList());
        }

        [HttpPost]
        public override IActionResult PostEntity([FromBody] BrandModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var brand = _brandMapper.MapModelToEntity(model);
            AddColors(brand, model);

            _brandRepository.Add(brand);
            return Ok(_brandMapper.MapEntityToReturnModel(brand));
        }

        [HttpPut("{id}")]
        public override IActionResult UpdateEntity([FromBody] BrandModel model, int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != model.Id)
                return BadRequest("Id van model komt niet overeen met id van query parameter");

            var brand = _brandMapper.MapModelToEntity(model);
            AddColors(brand, model);

            var isUpdated = _brandRepository.Update(id, brand);

            if (!isUpdated)
                return NotFound($"Geen merk gevonden met id {id}");

            return Ok();
        }

        private void AddColors(Brand brand, BrandModel brandModel)
        {
            AddExteriorColors(brand, brandModel);

            AddInteriorColors(brand, brandModel);
        }

        private void AddInteriorColors(Brand brand, BrandModel brandModel)
        {
            foreach (var brandModelInteriorColorId in brandModel.InteriorColorIds)
            {
                var color = _interiorColorRepository.GetById(brandModelInteriorColorId);
                if (color != null)
                    brand.InteriorColors.Add(color);
            }
        }

        private void AddExteriorColors(Brand brand, BrandModel brandModel)
        {
            foreach (var brandModelExteriorColorId in brandModel.ExteriorColorIds)
            {
                var color = _exteriorColorRepository.GetById(brandModelExteriorColorId);
                if (color != null)
                    brand.ExteriorColors.Add(color);
            }
        }
    }
}