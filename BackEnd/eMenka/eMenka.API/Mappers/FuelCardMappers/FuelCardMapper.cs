using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.FuelCardMappers
{
    public class FuelCardMapper : IMapper<FuelCard, FuelCardModel, FuelCardReturnModel>
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

        public FuelCardMapper()
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
            _exteriorColorMapper = new ExteriorColorMapper();
            _interiorColorMapper = new InteriorColorMapper();
        }

        public FuelCardReturnModel MapEntityToReturnModel(FuelCard entity)
        {
            if (entity == null)
                return null;
            return new FuelCardReturnModel
            {
                Driver = _driverMapper.MapEntityToReturnModel(entity.Driver),
                EndDate = entity.EndDate,
                StartDate = entity.StartDate,
                Company = entity.Company,
                Id = entity.Id,
                BlockingDate = entity.BlockingDate,
                BlockingReason = entity.BlockingReason,
                IsBlocked = entity.IsBlocked,
                PinCode = entity.PinCode,
                Number = entity.Number,
                Vehicle = MapVehicleEntity(entity.Vehicle)
            };
        }

        public FuelCard MapModelToEntity(FuelCardModel model)
        {
            return new FuelCard
            {
                DriverId = (int)model.DriverId,
                EndDate = model.EndDate,
                Id = model.Id,
                StartDate = model.StartDate,
                BlockingDate = model.BlockingDate,
                BlockingReason = model.BlockingReason,
                IsBlocked = model.IsBlocked,
                PinCode = model.PinCode,
                Number = model.Number,
                VehicleId = model.VehicleId,
                CompanyId = model.CompanyId
            };
        }

        private VehicleReturnModel MapVehicleEntity(Vehicle vehicle)
        {
            if (vehicle == null)
                return null;
            return new VehicleReturnModel
            {
                Id = vehicle.Id,
                Brand = _brandMapper.MapEntityToReturnModel(vehicle.Brand),
                FuelType = _fuelTypeMapper.MapEntityToReturnModel(vehicle.FuelType),
                EngineType = _engineTypeMapper.MapEntityToReturnModel(vehicle.EngineType),
                DoorType = _doorTypeMapper.MapEntityToReturnModel(vehicle.DoorType),
                Emission = vehicle.Emission,
                FiscalHP = vehicle.FiscalHP,
                IsActive = vehicle.IsActive,
                Volume = vehicle.Volume,
                Model = _modelMapper.MapEntityToReturnModel(vehicle.Model),
                Category = _categoryMapper.MapEntityToReturnModel(vehicle.Category),
                LicensePlate = vehicle.LicensePlate,
                Chassis = vehicle.Chassis,
                AverageFuel = vehicle.AverageFuel,
                EndDateDelivery = vehicle.EndDateDelivery,
                EngineCapacity = vehicle.EngineCapacity,
                EnginePower = vehicle.EnginePower,
                Serie = _serieMapper.MapEntityToReturnModel(vehicle.Series),
                BuildYear = vehicle.BuildYear,
                Country = _countryMapper.MapEntityToReturnModel(vehicle.Country),
                Kilometers = vehicle.Kilometers,
                RegistrationDate = vehicle.RegistrationDate,
                ExteriorColor = _exteriorColorMapper.MapExteriorColorEntity(vehicle.ExteriorColor),
                InteriorColor = _interiorColorMapper.MapInteriorColorEntity(vehicle.InteriorColor)
            };
        }
    }
}