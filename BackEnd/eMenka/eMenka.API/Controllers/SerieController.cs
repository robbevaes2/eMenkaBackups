﻿using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.StaticMappers;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SerieController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;
        private readonly ISerieRepository _serieRepository;

        public SerieController(ISerieRepository serieRepository, IBrandRepository brandRepository)
        {
            _serieRepository = serieRepository;
            _brandRepository = brandRepository;
        }

        [HttpGet]
        public IActionResult GetAllSeries()
        {
            var series = _serieRepository.GetAll();

            return Ok(series.Select(VehicleMappers.MapSerieEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetSerieById(int id)
        {
            var serie = _serieRepository.GetById(id);
            if (serie == null)
                return NotFound();

            return Ok(VehicleMappers.MapSerieEntity(serie));
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetSeriesByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var series = _serieRepository.Find(serie => serie.Brand.Id == brandId);

            return Ok(series.Select(VehicleMappers.MapSerieEntity).ToList());
        }

        [HttpGet("name/{serieName}")]
        public IActionResult GetSeriesByName(string serieName)
        {
            var series = _serieRepository.Find(serie => serie.Name == serieName);

            return Ok(series.Select(VehicleMappers.MapSerieEntity).ToList());
        }

        [HttpPost]
        public IActionResult PostSerie([FromBody] SerieModel serieModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (_brandRepository.GetById((int)serieModel.BrandId) == null)
                return NotFound($"No brand with id {serieModel.BrandId}");

            _serieRepository.Add(VehicleMappers.MapSerieModel(serieModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSerie([FromBody] SerieModel serieModel, int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != serieModel.Id)
                return BadRequest("Id from model does not match query parameter id");

            if (_brandRepository.GetById((int)serieModel.BrandId) == null)
                return NotFound($"No brand with id {serieModel.BrandId}");

            var isUpdated = _serieRepository.Update(id, VehicleMappers.MapSerieModel(serieModel));

            if (!isUpdated)
                return NotFound($"No Serie found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSerie(int id)
        {
            var serie = _serieRepository.GetById(id);
            if (serie == null)
                return NotFound();

            _serieRepository.Remove(serie);
            return Ok();
        }
    }
}