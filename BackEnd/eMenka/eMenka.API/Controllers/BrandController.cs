﻿using System;
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

            return Ok(brands.ToList().Select(VehicleMappers.MapBrandEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetBrandById(int id)
        {
            var brand = _brandRepository.GetById(id);
            if (brand == null)
                return NotFound();

            return Ok(VehicleMappers.MapBrandEntity(brand));
        }
        [HttpGet("name/{brandName}")]
        public IActionResult GetBrandsByName(string brandName)
        {
            var brands = _brandRepository.Find(brand => brand.Name == brandName);

            return Ok(brands.ToList().Select(VehicleMappers.MapBrandEntity).ToList());
        }

        [HttpPost]
        public IActionResult PostBrand([FromBody] BrandModel brandModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _brandRepository.Add(VehicleMappers.MapBrandModel(brandModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBrand([FromBody] BrandModel brandModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != brandModel.Id)
                return BadRequest("Id from model does not match id query parameter");
            var isUpdated = _brandRepository.Update(id, VehicleMappers.MapBrandModel(brandModel));

            if (!isUpdated)
                return NotFound($"No brand found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(int id)
        {
            var brand = _brandRepository.GetById(id);
            if (brand == null)
                return NotFound();

            _brandRepository.Remove(brand);
            return Ok();
        }
    }
}
