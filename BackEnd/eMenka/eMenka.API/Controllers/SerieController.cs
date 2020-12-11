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
    public class SerieController : GenericController<Series, SerieModel, SerieReturnModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly ISerieRepository _serieRepository;
        private readonly IMapper _mapper;

        public SerieController(ISerieRepository serieRepository, IBrandRepository brandRepository, IMapper mapper) : base(
            serieRepository, mapper)
        {
            _serieRepository = serieRepository;
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetSeriesByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"Merk met id {brandId} niet gevonden");

            var series = _serieRepository.Find(serie => serie.Brand.Id == brandId);

            return Ok(series.Select(_mapper.Map<SerieReturnModel>).ToList());
        }

        [HttpGet("name/{serieName}")]
        public IActionResult GetSeriesByName(string serieName)
        {
            var series = _serieRepository.Find(serie => serie.Name == serieName);

            return Ok(series.Select(_mapper.Map<SerieReturnModel>).ToList());
        }

        public override IActionResult PostEntity(SerieModel model)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"Merk met id {model.BrandId} niet gevonden");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(SerieModel model, int id)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"Merk met id {model.BrandId} niet gevonden");

            return base.UpdateEntity(model, id);
        }
    }
}