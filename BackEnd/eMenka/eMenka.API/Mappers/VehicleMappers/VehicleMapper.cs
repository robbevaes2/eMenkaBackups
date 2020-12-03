using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class VehicleMapper : IMapper<Vehicle, VehicleModel, VehicleReturnModel>
    {
        private readonly BrandMapper _brandMapper;
        private readonly CategoryMapper _categoryMapper;
        private readonly CountryMapper _countryMapper;
        private readonly DoorTypeMapper _doorTypeMapper;
        private readonly DriverMapper _driverMapper;
        private readonly EngineTypeMapper _engineTypeMapper;
        private readonly ExteriorColorMapper _exteriorColorMapper;
        private readonly FuelTypeMapper _fuelTypeMapper;
        private readonly InteriorColorMapper _interiorColorMapper;
        private readonly ModelMapper _modelMapper;
        private readonly SerieMapper _serieMapper;

        public VehicleMapper()
        {
            _brandMapper = new BrandMapper();
            _fuelTypeMapper = new FuelTypeMapper();
            _engineTypeMapper = new EngineTypeMapper();
            _doorTypeMapper = new DoorTypeMapper();
            _modelMapper = new ModelMapper();
            _categoryMapper = new CategoryMapper();
            _serieMapper = new SerieMapper();
            _countryMapper = new CountryMapper();
            _driverMapper = new DriverMapper();
            _interiorColorMapper = new InteriorColorMapper();
            _exteriorColorMapper = new ExteriorColorMapper();
        }

        public VehicleReturnModel MapEntityToReturnModel(Vehicle entity)
        {
            if (entity == null)
                return null;
            return new VehicleReturnModel
            {
                Id = entity.Id,
                Brand = _brandMapper.MapEntityToReturnModel(entity.Brand),
                FuelType = _fuelTypeMapper.MapEntityToReturnModel(entity.FuelType),
                EngineType = _engineTypeMapper.MapEntityToReturnModel(entity.EngineType),
                DoorType = _doorTypeMapper.MapEntityToReturnModel(entity.DoorType),
                Emission = entity.Emission,
                FiscalHP = entity.FiscalHP,
                IsActive = entity.IsActive,
                Volume = entity.Volume,
                Model = _modelMapper.MapEntityToReturnModel(entity.Model),
                FuelCard = MapFuelCardEntity(entity.FuelCard),
                Category = _categoryMapper.MapEntityToReturnModel(entity.Category),
                LicensePlate = entity.LicensePlate,
                Chassis = entity.Chassis,
                AverageFuel = entity.AverageFuel,
                EndDateDelivery = entity.EndDateDelivery,
                EngineCapacity = entity.EngineCapacity,
                EnginePower = entity.EnginePower,
                Serie = _serieMapper.MapEntityToReturnModel(entity.Series),
                BuildYear = entity.BuildYear,
                Country = _countryMapper.MapEntityToReturnModel(entity.Country),
                Kilometers = entity.Kilometers,
                RegistrationDate = entity.RegistrationDate,
                ExteriorColor = _exteriorColorMapper.MapExteriorColorEntity(entity.ExteriorColor),
                InteriorColor = _interiorColorMapper.MapInteriorColorEntity(entity.InteriorColor)
            };
        }

        public Vehicle MapModelToEntity(VehicleModel model)
        {
            return new Vehicle
            {
                Id = model.Id,
                EngineTypeId = (int) model.EngineTypeId,
                BrandId = (int) model.BrandId,
                DoorTypeId = (int) model.DoorTypeId,
                Emission = (int) model.Emission,
                FiscalHP = (int) model.FiscalHP,
                FuelTypeId = (int) model.FuelTypeId,
                IsActive = model.IsActive,
                ModelId = (int) model.ModelId,
                Volume = (int) model.Volume,
                LicensePlate = model.LicensePlate,
                FuelCardId = model.FuelCardId,
                SeriesId = (int) model.SeriesId,
                Chassis = model.Chassis,
                AverageFuel = model.AverageFuel,
                EndDateDelivery = model.EndDateDelivery,
                EngineCapacity = model.EngineCapacity,
                EnginePower = model.EnginePower,
                CountryId = model.CountryId,
                BuildYear = model.BuildYear,
                CategoryId = model.CategoryId,
                Kilometers = model.Kilometers,
                RegistrationDate = model.RegistrationDate,
                ExteriorColorId = model.ExteriorColorId,
                InteriorColorId = model.InteriorColorId
            };
        }

        private FuelCardReturnModel MapFuelCardEntity(FuelCard fuelCard)
        {
            if (fuelCard == null)
                return null;
            return new FuelCardReturnModel
            {
                Driver = _driverMapper.MapEntityToReturnModel(fuelCard.Driver),
                EndDate = fuelCard.EndDate,
                StartDate = fuelCard.StartDate,
                Id = fuelCard.Id,
                BlockingDate = fuelCard.BlockingDate,
                BlockingReason = fuelCard.BlockingReason,
                IsBlocked = fuelCard.IsBlocked,
                PinCode = fuelCard.PinCode,
                Number = fuelCard.Number
            };
        }
    }
}