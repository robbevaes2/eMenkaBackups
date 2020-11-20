using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers
{
    public static class VehicleMappers
    {
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
                Model = MapModelEntity(vehicle.Model),
                FuelCard = FuelCardMappers.MapFuelCardEntity(vehicle.FuelCard) ,
                Category = MapCategoryEntity(vehicle.Category),
                LicensePlate = vehicle.LicensePlate,
                Chassis = vehicle.Chassis,
                AverageFuel = vehicle.AverageFuel,
                EndDateDelivery = vehicle.EndDateDelivery,
                EngineCapacity = vehicle.EngineCapacity,
                EnginePower = vehicle.EnginePower,
                Serie = MapSerieEntity(vehicle.Series)
            };
        }

        public static Vehicle MapVehicleModel(VehicleModel vehicleModel)
        {
            return new Vehicle
            {
                Id = vehicleModel.Id,
                EngineTypeId = (int)vehicleModel.EngineTypeId,
                BrandId = (int)(int)vehicleModel.BrandId,
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
                CategoryId = (int)vehicleModel.CategoryId
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
            return new EngineType()
            {
                BrandId = (int)engineTypeModel.BrandId,
                Id = engineTypeModel.Id,
                Name = engineTypeModel.Name
            };
        }

        public static ModelReturnModel MapModelEntity(Model model)
        {
            if (model == null)
                return null;
            return new ModelReturnModel
            {
                Brand = MapBrandEntity(model.Brand),
                Name = model.Name,
                Id = model.Id
            };
        }
        public static Model MapModelModel(ModelModel modelModel)
        {
            return new Model
            {
                BrandId = (int)modelModel.BrandId,
                Id = modelModel.Id,
                Name = modelModel.Name
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
                Id = brand.Id
                //ExteriorColors = brand.ExteriorColors.Select(MapExteriorColorEntity()).ToList(),
                //InteriorColors = brand.InteriorColors.Select(MapInteriorColorEntity()).ToList()
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
        /*
        private static Func<InteriorColor, InteriorColorReturnModel> MapInteriorColorEntity()
        {
            return ic => new InteriorColorReturnModel
            {
                Id = ic.Id,
                BrandId = ic.BrandId,
                Code = ic.Code,
                Name = ic.Name
            };
        }

        private static Func<ExteriorColor, ExteriorColorReturnModel> MapExteriorColorEntity()
        {
            return ec => new ExteriorColorReturnModel
            {
                BrandId = ec.BrandId,
                Code = ec.Code,
                Id = ec.Id,
                Name = ec.Name
            };
        }*/
    }
}
