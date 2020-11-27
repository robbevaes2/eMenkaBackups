using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.FuelCardMappers
{
    public class FuelCardMapper : IMapper<FuelCard, FuelCardModel, FuelCardReturnModel>
    {
        private BrandMapper _brandMapper;
        private FuelTypeMapper _fuelTypeMapper;
        private EngineTypeMapper _engineTypeMapper;
        private DoorTypeMapper _doorTypeMapper;
        private ModelMapper _modelMapper;
        private CategoryMapper _categoryMapper;
        private SerieMapper _serieMapper;
        private CountryMapper _countryMapper;
        private DriverMapper _driverMapper;
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
                VehicleId = model.VehicleId
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
                Power = vehicle.Power,
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
                RegistrationDate = vehicle.RegistrationDate
            };
        }
    }
}
