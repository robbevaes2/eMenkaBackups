using System.Collections.Generic;
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
    public class VehicleController : GenericController<Vehicle, VehicleModel, VehicleReturnModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDoorTypeRepository _doorTypeRepository;
        private readonly IEngineTypeRepository _engineTypeRepository;
        private readonly IFuelCardRepository _fuelCardRepository;
        private readonly IRecordRepository _recordRepository;
        private readonly IFuelTypeRepository _fuelTypeRepository;
        private readonly IModelRepository _modelRepository;
        private readonly ISerieRepository _serieRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly VehicleMapper _vehicleMapper;

        public VehicleController(IVehicleRepository vehicleRepository, IBrandRepository brandRepository,
            IModelRepository modelRepository, IFuelTypeRepository fuelTypeRepository,
            IEngineTypeRepository engineTypeRepository, IDoorTypeRepository doorTypeRepository,
            ICategoryRepository categoryRepository, ISerieRepository serieRepository,
            IFuelCardRepository fuelCardRepository, IRecordRepository recordRepository) : base(vehicleRepository, new VehicleMapper())
        {
            _vehicleRepository = vehicleRepository;
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
            _fuelTypeRepository = fuelTypeRepository;
            _engineTypeRepository = engineTypeRepository;
            _doorTypeRepository = doorTypeRepository;
            _categoryRepository = categoryRepository;
            _fuelCardRepository = fuelCardRepository;
            _recordRepository = recordRepository;
            _serieRepository = serieRepository;
            _vehicleMapper = new VehicleMapper();
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetVehicleByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"Merk met id {brandId} niet gevonden");

            var vehicles = _vehicleRepository.Find(vehicle => vehicle.BrandId == brandId);

            return Ok(vehicles.Select(_vehicleMapper.MapEntityToReturnModel).ToList());
        }

        [HttpGet("available/brand/{brandId}")]
        public IActionResult GetAvailableVehicleByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"Merk met id {brandId} niet gevonden");

            var records = _recordRepository.GetAll();

            var vehicles = _vehicleRepository.GetAllAvailableVehiclesByBrandId(brandId, records.Select(r => r.FuelCardId).ToList());

            return Ok(vehicles.Select(_vehicleMapper.MapEntityToReturnModel).ToList());
        }

        [HttpGet("available")]
        public IActionResult GetAllAvailableVehicles()
        {
            var vehicles = _vehicleRepository.GetAllAvailableVehicles();
            return Ok(vehicles.Select(_vehicleMapper.MapEntityToReturnModel).ToList());
        }

        [HttpGet("brand/name/{brandName}")]
        public IActionResult GetVehiclesByBrandName(string brandName)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.Brand.Name == brandName);

            return Ok(vehicles.Select(_vehicleMapper.MapEntityToReturnModel).ToList());
        }

        [HttpGet("model/{modelId}")]
        public IActionResult GetVehicleByModelId(int modelId)
        {
            if (_modelRepository.GetById(modelId) == null)
                return NotFound($"Model met id {modelId} niet gevonden");

            var vehicles = _vehicleRepository.Find(vehicle => vehicle.ModelId == modelId);

            return Ok(vehicles.Select(_vehicleMapper.MapEntityToReturnModel).ToList());
        }

        [HttpGet("isActive/{isActive}")]
        public IActionResult GetVehicleByStatus(bool isActive)
        {
            var vehicles = _vehicleRepository.Find(vehicle => vehicle.IsActive == isActive);

            return Ok(vehicles.Select(_vehicleMapper.MapEntityToReturnModel).ToList());
        }

        public override IActionResult PostEntity(VehicleModel model)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"Merk met id {model.BrandId} niet gevonden");

            if (_modelRepository.GetById((int)model.ModelId) == null)
                return NotFound($"Model met id {model.ModelId} niet gevonden");

            if (_fuelTypeRepository.GetById((int)model.FuelTypeId) == null)
                return NotFound($"Brandstoftype met id {model.FuelTypeId} niet gevonden");

            if (_engineTypeRepository.GetById((int)model.EngineTypeId) == null)
                return NotFound($"Motortype met id {model.EngineTypeId} niet gevonden");

            if (_doorTypeRepository.GetById((int)model.DoorTypeId) == null)
                return NotFound($"Deurtype met id {model.DoorTypeId} niet gevonden");

            if (_categoryRepository.GetById((int)model.CategoryId) == null)
                return NotFound($"Categorie met id {model.CategoryId} niet gevonden");

            if (model.FuelCardId != null)
            {
                if (_fuelCardRepository.GetById((int)model.FuelCardId) == null)
                    return NotFound($"Tankkaart met id {model.FuelCardId} niet gevonden");


                if (_vehicleRepository.Find(v => v.FuelCard.Id == model.FuelCardId).FirstOrDefault() != null)
                    return BadRequest($"Een voertuig met tankkaart id {model.FuelCardId} bestaat al");
            }

            if (_serieRepository.GetById((int)model.SeriesId) == null)
                return NotFound($"Serie met id {model.SeriesId} niet gevonden");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(VehicleModel model, int id)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"Merk met id {model.BrandId} niet gevonden");

            if (_modelRepository.GetById((int)model.ModelId) == null)
                return NotFound($"Model met id {model.ModelId} niet gevonden");

            if (_fuelTypeRepository.GetById((int)model.FuelTypeId) == null)
                return NotFound($"Brandstoftype met id {model.FuelTypeId} niet gevonden");

            if (_engineTypeRepository.GetById((int)model.EngineTypeId) == null)
                return NotFound($"Motortype met id {model.EngineTypeId} niet gevonden");

            if (_doorTypeRepository.GetById((int)model.DoorTypeId) == null)
                return NotFound($"Deurtype met id {model.DoorTypeId} niet gevonden");

            if (_categoryRepository.GetById((int)model.CategoryId) == null)
                return NotFound($"Categorie met id {model.CategoryId} niet gevonden");

            if (model.FuelCardId != null)
            {
                if (_fuelCardRepository.GetById((int)model.FuelCardId) == null)
                    return NotFound($"Tankkaart met id {model.FuelCardId} niet gevonden");

                var vehicle = _vehicleRepository.Find(v => v.FuelCard.Id == model.FuelCardId).FirstOrDefault();

                if (vehicle != null && vehicle.Id != model.Id)
                    return BadRequest($"Een voertuig met tankkaart id {model.FuelCardId} bestaat al");
            }

            if (_serieRepository.GetById((int)model.SeriesId) == null)
                return NotFound($"Serie met id {model.SeriesId} niet gevonden");

            return base.UpdateEntity(model, id);
        }
    }
}