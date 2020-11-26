using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Mappers.StaticMappers;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class VehicleMapper : IMapper<Vehicle, VehicleModel, VehicleReturnModel>
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
                Power = entity.Power,
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
                Kilometers = entity.Kilometers
            };
        }

        public Vehicle MapModelToEntity(VehicleModel model)
        {
            return new Vehicle
            {
                Id = model.Id,
                EngineTypeId = (int)model.EngineTypeId,
                BrandId = (int)model.BrandId,
                DoorTypeId = (int)model.DoorTypeId,
                Emission = (int)model.Emission,
                FiscalHP = (int)model.FiscalHP,
                FuelTypeId = (int)model.FuelTypeId,
                IsActive = model.IsActive,
                ModelId = (int)model.ModelId,
                Power = (int)model.Power,
                Volume = (int)model.Volume,
                LicensePlate = model.LicensePlate,
                FuelCardId = (int)model.FuelCardId,
                SeriesId = (int)model.SeriesId,
                Chassis = model.Chassis,
                AverageFuel = model.AverageFuel,
                EndDateDelivery = model.EndDateDelivery,
                EngineCapacity = model.EngineCapacity,
                EnginePower = model.EnginePower,
                CountryId = model.CountryId,
                BuildYear = model.BuildYear,
                CategoryId = model.CategoryId,
                Kilometers = model.Kilometers
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
