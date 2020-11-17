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
    public class BrandController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;

        public BrandController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        [HttpGet]
        public IActionResult GetAllBrands()
        {
            var brands = _brandRepository.GetAll();
            if (brands == null)
                return BadRequest();

            return Ok(brands.ToList().Select(MapBrandEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetBrandById(int id)
        {
            var brand = _brandRepository.GetById(id);
            if (brand == null)
                return BadRequest();

            return Ok(MapBrandEntity(brand));
        }
        [HttpGet("{brandName}")]
        public IActionResult GetBrandByName(string brandName)
        {
            var brands = _brandRepository.Find(brand => brand.Name == brandName);
            if (brands == null)
                return BadRequest();

            return Ok(brands.ToList().Select(MapBrandEntity));
        }

        [HttpPost]
        public IActionResult PostBrand([FromBody] BrandModel brandModel)
        {
            _brandRepository.Add(MapBrandModel(brandModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBrand([FromBody] BrandModel brandModel, int id)
        {
            var isUpdated = _brandRepository.Update(id, MapBrandModel(brandModel));

            if (!isUpdated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(int id)
        {
            var brand = _brandRepository.GetById(id);
            if (brand == null)
                return BadRequest();

            _brandRepository.Remove(brand);
            return Ok();
        }

        public Brand MapBrandModel(BrandModel brandModel)
        {
            return new Brand
            {
                Id = brandModel.Id,
                Name = brandModel.Name
            };
        }

        public BrandModel MapBrandEntity(Brand brand)
        {
            return new BrandModel
            {
                Name = brand.Name,
                Id = brand.Id,
                ExteriorColors = brand.ExteriorColors.Select(MapExteriorColorEntity()).ToList(),
                InteriorColors = brand.InteriorColors.Select(MapInteriorColorEntity()).ToList(),
                Models = brand.Models.Select(MapModelEntity()).ToList(),
                EngineTypes = brand.EngineTypes.Select(MapEngineTypeEntity()).ToList(),
                Series = brand.Series.Select(MapSerieEntity()).ToList()
            };
        }

        private static Func<Serie, SerieModel> MapSerieEntity()
        {
            return s => new SerieModel
            {
                BrandId = s.BrandId,
                Name = s.Name,
                Id = s.Id
            };
        }

        private static Func<EngineType, EngineTypeModel> MapEngineTypeEntity()
        {
            return mt => new EngineTypeModel
            {
                BrandId = mt.BrandId,
                Id = mt.Id,
                Name = mt.Name
            };
        }

        private static Func<Model, ModelModel> MapModelEntity()
        {
            return m => new ModelModel
            {
                BrandId = m.BrandId,
                Name = m.Name,
                Id = m.Id
            };
        }

        private static Func<InteriorColor, InteriorColorModel> MapInteriorColorEntity()
        {
            return ic => new InteriorColorModel
            {
                Id = ic.Id,
                BrandId = ic.BrandId,
                Code = ic.Code,
                Name = ic.Name
            };
        }

        private static Func<ExteriorColor, ExteriorColorModel> MapExteriorColorEntity()
        {
            return ec => new ExteriorColorModel
            {
                BrandId = ec.BrandId,
                Code = ec.Code,
                Id = ec.Id,
                Name = ec.Name
            };
        }
    }
}
