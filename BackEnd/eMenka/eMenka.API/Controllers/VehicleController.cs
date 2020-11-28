using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

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
        private readonly IFuelTypeRepository _fuelTypeRepository;
        private readonly IModelRepository _modelRepository;
        private readonly ISerieRepository _serieRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private VehicleMapper _vehicleMapper;

        public VehicleController(IVehicleRepository vehicleRepository, IBrandRepository brandRepository,
            IModelRepository modelRepository, IFuelTypeRepository fuelTypeRepository,
            IEngineTypeRepository engineTypeRepository, IDoorTypeRepository doorTypeRepository,
            ICategoryRepository categoryRepository, ISerieRepository serieRepository,
            IFuelCardRepository fuelCardRepository) : base(vehicleRepository, new VehicleMapper())
        {
            _vehicleRepository = vehicleRepository;
            _brandRepository = brandRepository;
            _modelRepository = modelRepository;
            _fuelTypeRepository = fuelTypeRepository;
            _engineTypeRepository = engineTypeRepository;
            _doorTypeRepository = doorTypeRepository;
            _categoryRepository = categoryRepository;
            _fuelCardRepository = fuelCardRepository;
            _serieRepository = serieRepository;
            _vehicleMapper = new VehicleMapper();
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetVehicleByBrandId(int brandId)
        {
            if (_brandRepository.GetById(brandId) == null)
                return NotFound($"No brand with id {brandId}");

            var vehicles = _vehicleRepository.Find(vehicle => vehicle.BrandId == brandId);

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
                return NotFound($"No model with id {modelId}");

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
                return NotFound($"No brand with id {model.BrandId}");

            if (_modelRepository.GetById((int)model.ModelId) == null)
                return NotFound($"No model with id {model.ModelId}");

            if (_fuelTypeRepository.GetById((int)model.FuelTypeId) == null)
                return NotFound($"No fuelType with id {model.FuelTypeId}");

            if (_engineTypeRepository.GetById((int)model.EngineTypeId) == null)
                return NotFound($"No motortype with id {model.EngineTypeId}");

            if (_doorTypeRepository.GetById((int)model.DoorTypeId) == null)
                return NotFound($"No doortype with id {model.DoorTypeId}");

            if (_categoryRepository.GetById((int)model.CategoryId) == null)
                return NotFound($"No category with id {model.CategoryId}");

            if (model.FuelCardId != null)
            {
                if (_fuelCardRepository.GetById((int)model.FuelCardId) == null)
                    return NotFound($"No fuelcard with id {model.FuelCardId}");


                if (_vehicleRepository.Find(v => v.FuelCard.Id == model.FuelCardId).FirstOrDefault() != null)
                    return BadRequest($"A vehicle already exists with fuelcard id {model.FuelCardId}");
            }

            if (_serieRepository.GetById((int)model.SeriesId) == null)
                return NotFound($"No serie with id {model.SeriesId}");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(VehicleModel model, int id)
        {
            if (_brandRepository.GetById((int)model.BrandId) == null)
                return NotFound($"No brand with id {model.BrandId}");

            if (_modelRepository.GetById((int)model.ModelId) == null)
                return NotFound($"No model with id {model.ModelId}");

            if (_fuelTypeRepository.GetById((int)model.FuelTypeId) == null)
                return NotFound($"No fuelType with id {model.FuelTypeId}");

            if (_engineTypeRepository.GetById((int)model.EngineTypeId) == null)
                return NotFound($"No motortype with id {model.EngineTypeId}");

            if (_doorTypeRepository.GetById((int)model.DoorTypeId) == null)
                return NotFound($"No doortype with id {model.DoorTypeId}");

            if (_categoryRepository.GetById((int)model.CategoryId) == null)
                return NotFound($"No category with id {model.CategoryId}");

            if (model.FuelCardId != null)
            {
                if (_fuelCardRepository.GetById((int)model.FuelCardId) == null)
                    return NotFound($"No fuelcard with id {model.FuelCardId}");

                var vehicle = _vehicleRepository.Find(v => v.FuelCard.Id == model.FuelCardId).FirstOrDefault();

                if (vehicle != null && vehicle.Id != model.Id)
                    return BadRequest($"A vehicle already exists with fuelcard id {model.FuelCardId}");
            }

            if (_serieRepository.GetById((int)model.SeriesId) == null)
                return NotFound($"No serie with id {model.SeriesId}");

            return base.UpdateEntity(model, id);
        }
    }
}