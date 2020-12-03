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
    public class SerieController : GenericController<Series, SerieModel, SerieReturnModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly ISerieRepository _serieRepository;
        private readonly SerieMapper _serieMapper;

        public SerieController(ISerieRepository serieRepository, IBrandRepository brandRepository) : base(
            serieRepository, new SerieMapper())
        {
            _serieRepository = serieRepository;
            _brandRepository = brandRepository;
            _serieMapper = new SerieMapper();
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetSeriesByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var series = _serieRepository.Find(serie => serie.Brand.Id == brandId);

            return Ok(series.Select(_serieMapper.MapEntityToReturnModel).ToList());
        }

        [HttpGet("name/{serieName}")]
        public IActionResult GetSeriesByName(string serieName)
        {
            var series = _serieRepository.Find(serie => serie.Name == serieName);

            return Ok(series.Select(_serieMapper.MapEntityToReturnModel).ToList());
        }

        public override IActionResult PostEntity(SerieModel model)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(SerieModel model, int id)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            return base.UpdateEntity(model, id);
        }
    }
}