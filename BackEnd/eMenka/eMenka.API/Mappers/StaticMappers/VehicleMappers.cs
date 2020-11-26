﻿using System.Linq;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.StaticMappers
{
    public static class VehicleMappers
    {
        static ModelMapper modelMapper = new ModelMapper();
        public static VehicleReturnModel MapVehicleEntity(Vehicle vehicle)
        {
            if (vehicle == null)
                return null;
            return new VehicleReturnModel
            {
                Id = vehicle.Id,
                Brand = MapBrandEntity(vehicle.Brand),
                FuelType = MapFuelTypeEntity(vehicle.FuelType),
                EngineType = MapEngineTypeEntity(vehicle.EngineType),
                DoorType = MapDoorTypeEntity(vehicle.DoorType),
                Emission = vehicle.Emission,
                FiscalHP = vehicle.FiscalHP,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                Model = modelMapper.MapEntityToReturnModel(vehicle.Model),
                FuelCard = FuelCardMapper.MapFuelCardEntity(vehicle.FuelCard),
                Category = MapCategoryEntity(vehicle.Category),
                LicensePlate = vehicle.LicensePlate,
                Chassis = vehicle.Chassis,
                AverageFuel = vehicle.AverageFuel,
                EndDateDelivery = vehicle.EndDateDelivery,
                EngineCapacity = vehicle.EngineCapacity,
                EnginePower = vehicle.EnginePower,
                Serie = MapSerieEntity(vehicle.Series),
                BuildYear = vehicle.BuildYear,
                Country = MapCountryEntity(vehicle.Country),
                Kilometers = vehicle.Kilometers
            };
        }

        public static Vehicle MapVehicleModel(VehicleModel vehicleModel)
        {
            return new Vehicle
            {
                Id = vehicleModel.Id,
                EngineTypeId = (int)vehicleModel.EngineTypeId,
                BrandId = (int)vehicleModel.BrandId,
                DoorTypeId = (int)vehicleModel.DoorTypeId,
                Emission = (int)vehicleModel.Emission,
                FiscalHP = (int)vehicleModel.FiscalHP,
                FuelTypeId = (int)vehicleModel.FuelTypeId,
                IsActive = vehicleModel.IsActive,
                ModelId = (int)vehicleModel.ModelId,
                Power = (int)vehicleModel.Power,
                Volume = (int)vehicleModel.Volume,
                LicensePlate = vehicleModel.LicensePlate,
                FuelCardId = (int)vehicleModel.FuelCardId,
                SeriesId = (int)vehicleModel.SeriesId,
                Chassis = vehicleModel.Chassis,
                AverageFuel = vehicleModel.AverageFuel,
                EndDateDelivery = vehicleModel.EndDateDelivery,
                EngineCapacity = vehicleModel.EngineCapacity,
                EnginePower = vehicleModel.EnginePower,
                CountryId = vehicleModel.CountryId,
                BuildYear = vehicleModel.BuildYear,
                CategoryId = vehicleModel.CategoryId,
                Kilometers = vehicleModel.Kilometers
            };
        }

        public static SerieReturnModel MapSerieEntity(Series series)
        {
            if (series == null)
                return null;
            return new SerieReturnModel
            {
                Brand = MapBrandEntity(series.Brand),
                Name = series.Name,
                Id = series.Id
            };
        }

        public static Series MapSerieModel(SerieModel serieModel)
        {
            return new Series
            {
                BrandId = (int)serieModel.BrandId,
                Id = serieModel.Id,
                Name = serieModel.Name
            };
        }

        public static EngineTypeReturnModel MapEngineTypeEntity(EngineType engineType)
        {
            if (engineType == null)
                return null;
            return new EngineTypeReturnModel
            {
                Brand = MapBrandEntity(engineType.Brand),
                Name = engineType.Name,
                Id = engineType.Id
            };
        }

        public static EngineType MapEngineTypeModel(EngineTypeModel engineTypeModel)
        {
            return new EngineType
            {
                BrandId = (int)engineTypeModel.BrandId,
                Id = engineTypeModel.Id,
                Name = engineTypeModel.Name
            };
        }

        public static Brand MapBrandModel(BrandModel brandModel)
        {
            return new Brand
            {
                Id = brandModel.Id,
                Name = brandModel.Name
            };
        }

        public static BrandReturnModel MapBrandEntity(Brand brand)
        {
            if (brand == null)
                return null;
            return new BrandReturnModel
            {
                Name = brand.Name,
                Id = brand.Id,
                ExteriorColors = brand.ExteriorColors.Select(MapExteriorColorEntity).ToList(),
                InteriorColors = brand.InteriorColors.Select(MapInteriorColorEntity).ToList()
            };
        }

        public static FuelTypeReturnModel MapFuelTypeEntity(FuelType fuelType)
        {
            if (fuelType == null)
                return null;
            return new FuelTypeReturnModel
            {
                Id = fuelType.Id,
                Code = fuelType.Code,
                Name = fuelType.Name
            };
        }

        public static FuelType MapFuelTypeModel(FuelTypeModel fuelTypeModel)
        {
            return new FuelType
            {
                Code = fuelTypeModel.Code,
                Id = fuelTypeModel.Id,
                Name = fuelTypeModel.Name
            };
        }

        public static DoorTypeReturnModel MapDoorTypeEntity(DoorType doorType)
        {
            if (doorType == null)
                return null;
            return new DoorTypeReturnModel
            {
                Id = doorType.Id,
                Name = doorType.Name
            };
        }

        public static DoorType MapDoorTypeModel(DoorTypeModel doorTypeModel)
        {
            return new DoorType
            {
                Id = doorTypeModel.Id,
                Name = doorTypeModel.Name
            };
        }

        public static CategoryReturnModel MapCategoryEntity(Category category)
        {
            if (category == null)
                return null;
            return new CategoryReturnModel
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        public static Category MapCategoryModel(CategoryModel categoryModel)
        {
            return new Category
            {
                Name = categoryModel.Name,
                Id = categoryModel.Id
            };
        }

        public static CountryReturnModel MapCountryEntity(Country country)
        {
            if (country == null)
                return null;
            return new CountryReturnModel
            {
                Code = country.Code,
                Id = country.Id,
                IsActive = country.IsActive,
                Name = country.Name,
                Nationality = country.Nationality,
                POD = country.POD
            };
        }

        public static Country MapCountryModel(CountryModel countryModel)
        {
            return new Country
            {
                POD = countryModel.POD,
                Code = countryModel.Code,
                Id = countryModel.Id,
                IsActive = countryModel.IsActive,
                Name = countryModel.Name,
                Nationality = countryModel.Nationality
            };
        }

        
        public static InteriorColorReturnModel MapInteriorColorEntity(InteriorColor interiorColor)
        {
            return  new InteriorColorReturnModel
            {
                Id = interiorColor.Id,
                Code = interiorColor.Code,
                Name = interiorColor.Name
            };
        }

        public static ExteriorColorReturnModel MapExteriorColorEntity(ExteriorColor exteriorColor)
        {
            return  new ExteriorColorReturnModel
            {
                Code = exteriorColor.Code,
                Id = exteriorColor.Id,
                Name = exteriorColor.Name
            };
        }
    }
}