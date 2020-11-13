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
    public class SerieController : ControllerBase
    {
        private readonly ISerieRepository _serieRepository;

        public SerieController(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        [HttpGet]
        public IActionResult GetAllSeries()
        {
            var series = _serieRepository.GetAll();
            if (series == null)
                return BadRequest();

            return Ok(series.ToList().Select(VehicleMappers.MapSerieEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetSeriesById(int id)
        {
            var serie = _serieRepository.GetById(id);
            if (serie == null)
                return BadRequest();

            return Ok(VehicleMappers.MapSerieEntity(serie));
        }

        [HttpGet("{brandId}")]
        public IActionResult GetSeriesByBrandId(int brandId)
        {
            var series = _serieRepository.Find(serie => serie.Brand.Id == brandId);
            if (series == null)
                return BadRequest();

            return Ok(series.ToList().Select(VehicleMappers.MapSerieEntity));
        }

        [HttpGet("{serieName}")]
        public IActionResult GetSerieByName(string serieName)
        {
            var series = _serieRepository.Find(serie => serie.Name == serieName);
            if (series == null)
                return BadRequest();

            return Ok(series.ToList().Select(VehicleMappers.MapSerieEntity));
        }

        [HttpPost]
        public IActionResult PostSerie([FromBody] SerieModel serieModel)
        {
            _serieRepository.Add(VehicleMappers.MapSerieModel(serieModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSerie([FromBody] SerieModel serieModel, int id)
        {
            if(id != serieModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _serieRepository.Update(id, VehicleMappers.MapSerieModel(serieModel));

            if (!isUpdated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSerie(int id)
        {
            var serie = _serieRepository.GetById(id);
            if (serie == null)
                return BadRequest();

            _serieRepository.Remove(serie);
            return Ok();
        }
    }
}
