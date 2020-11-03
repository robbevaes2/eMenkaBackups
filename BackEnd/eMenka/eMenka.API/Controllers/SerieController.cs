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

            return Ok(series.ToList().Select(MapSerieEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetSeriesById(int id)
        {
            var serie = _serieRepository.GetById(id);
            if (serie == null)
                return BadRequest();

            return Ok(MapSerieEntity(serie));
        }

        [HttpGet("{serieName}")]
        public IActionResult GetBrandByName(string serieName)
        {
            var series = _serieRepository.Find(seroe => seroe.Name == serieName);
            if (series == null)
                return BadRequest();

            return Ok(series.ToList().Select(MapSerieEntity));
        }

        [HttpPost]
        public IActionResult PostSerie([FromBody] SerieModel serieModel)
        {
            _serieRepository.Add(MapSerieModel(serieModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSerie([FromBody] SerieModel serieModel, int id)
        {
            var isUpdated = _serieRepository.Update(id, MapSerieModel(serieModel));

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

        private SerieModel MapSerieEntity(Serie serie)
        {
            return new SerieModel
            {
                BrandId = serie.BrandId,
                Name = serie.Name,
                Id = serie.Id
            };
        }
        private Serie MapSerieModel(SerieModel serieModel)
        {
            return new Serie
            {
                BrandId = serieModel.BrandId,
                Id = serieModel.Id,
                Name = serieModel.Name
            };
        }
    }
}
