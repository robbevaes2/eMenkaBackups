using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.StaticMappers
{
    public static class FuelCardMapper
    {
        private static PersonMapper _personMapper = new PersonMapper();
        static ModelMapper _modelMapper = new ModelMapper();
        public static FuelCardReturnModel MapFuelCardEntity(FuelCard fuelCard)
        {
            if (fuelCard == null)
                return null;
            return new FuelCardReturnModel
            {
                Driver = MapDriverEntity(fuelCard.Driver),
                EndDate = fuelCard.EndDate,
                StartDate = fuelCard.StartDate,
                Id = fuelCard.Id,
                BlockingDate = fuelCard.BlockingDate,
                BlockingReason = fuelCard.BlockingReason,
                IsBlocked = fuelCard.IsBlocked,
                PinCode = fuelCard.PinCode,
                Number = fuelCard.Number,
                Vehicle = MapVehicleEntity(fuelCard.Vehicle)
            };
        }

        public static FuelCard MapFuelCardModel(FuelCardModel fuelCardModel)
        {
            return new FuelCard
            {
                DriverId = (int)fuelCardModel.DriverId,
                EndDate = fuelCardModel.EndDate,
                Id = fuelCardModel.Id,
                StartDate = fuelCardModel.StartDate,
                BlockingDate = fuelCardModel.BlockingDate,
                BlockingReason = fuelCardModel.BlockingReason,
                IsBlocked = fuelCardModel.IsBlocked,
                PinCode = fuelCardModel.PinCode,
                Number = fuelCardModel.Number,
                VehicleId = fuelCardModel.VehicleId
            };
        }

        public static VehicleReturnModel MapVehicleEntity(Vehicle vehicle)
        {
            if (vehicle == null)
                return null;
            return new VehicleReturnModel
            {
                Id = vehicle.Id,
                Brand = VehicleMappers.MapBrandEntity(vehicle.Brand),
                FuelType = VehicleMappers.MapFuelTypeEntity(vehicle.FuelType),
                EngineType = VehicleMappers.MapEngineTypeEntity(vehicle.EngineType),
                DoorType = VehicleMappers.MapDoorTypeEntity(vehicle.DoorType),
                Emission = vehicle.Emission,
                FiscalHP = vehicle.FiscalHP,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                Model = _modelMapper.MapEntityToReturnModel(vehicle.Model),
                Category = VehicleMappers.MapCategoryEntity(vehicle.Category),
                LicensePlate = vehicle.LicensePlate,
                Chassis = vehicle.Chassis,
                AverageFuel = vehicle.AverageFuel,
                EndDateDelivery = vehicle.EndDateDelivery,
                EngineCapacity = vehicle.EngineCapacity,
                EnginePower = vehicle.EnginePower,
                Serie = VehicleMappers.MapSerieEntity(vehicle.Series),
                BuildYear = vehicle.BuildYear,
                Country = VehicleMappers.MapCountryEntity(vehicle.Country)
            };
        }

        public static DriverReturnModel MapDriverEntity(Driver driver)
        {
            if (driver == null)
                return null;
            return new DriverReturnModel
            {
                EndDate = driver.EndDate,
                StartDate = driver.StartDate,
                Id = driver.Id,
                Person = _personMapper.MapEntityToReturnModel(driver.Person)
            };
        }

        public static Driver MapDriverModel(DriverModel driverModel)
        {
            return new Driver
            {
                Id = driverModel.Id,
                EndDate = driverModel.EndDate,
                PersonId = (int)driverModel.PersonId,
                StartDate = driverModel.StartDate
            };
        }
    }
}