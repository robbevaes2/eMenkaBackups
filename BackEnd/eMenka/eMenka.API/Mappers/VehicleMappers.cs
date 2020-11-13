using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.VehicleModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers
{
    public static class VehicleMappers
    {
        public static VehicleModel MapVehicleEntity(Vehicle vehicle)
        {
            return new VehicleModel
            {
                Id = vehicle.Id,
                Brand = MapBrandEntity(vehicle.Brand),
                FuelType = MapFuelTypeEntity(vehicle.FuelType),
                MotorType = MapMotorTypeEntity(vehicle.MotorType),
                DoorType = MapDoorTypeEntity(vehicle.DoorType), 
                Emission = vehicle.Emission,
                EndDate = vehicle.EndDate,
                FiscalePk = vehicle.FiscalePk,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                Model = MapModelEntity(vehicle.Model),
                FuelCard = vehicle.FuelCard.Id 
            };
        }

        public static Vehicle MapVehicleModel(VehicleModel vehicleModel)
        {
            return new Vehicle
            {
                Id = vehicleModel.Id,
                MotorTypeId = vehicleModel.MotorType.Id,
                BrandId = vehicleModel.Brand.Id,
                DoorTypeId = vehicleModel.DoorType.Id,
                Emission = vehicleModel.Emission,
                EndDate = vehicleModel.EndDate,
                FiscalePk = vehicleModel.FiscalePk,
                FuelTypeId = vehicleModel.FuelType.Id, 
                IsActive = vehicleModel.IsActive,
                ModelId = vehicleModel.Model.Id,
                Power = vehicleModel.Power,
                Volume = vehicleModel.Volume,
                FuelCardId = vehicleModel.FuelCard//.Id 
            };
        }

        public static SerieModel MapSerieEntity(Serie serie)
        {
            return new SerieModel
            {
                Brand = MapBrandEntity(serie.Brand),
                Name = serie.Name,
                Id = serie.Id
            };
        }
        public static Serie MapSerieModel(SerieModel serieModel)
        {
            return new Serie
            {
                BrandId = serieModel.Brand.Id,
                Id = serieModel.Id,
                Name = serieModel.Name
            };
        }

        public static MotorTypeModel MapMotorTypeEntity(MotorType motorType)
        {
            return new MotorTypeModel
            {
                Brand = MapBrandEntity(motorType.Brand),
                Name = motorType.Name,
                Id = motorType.Id
            };
        }
        public static MotorType MapMotorTypeModel(MotorTypeModel motorTypeModel)
        {
            return new MotorType
            {
                BrandId = motorTypeModel.Brand.Id,
                Id = motorTypeModel.Id,
                Name = motorTypeModel.Name
            };
        }

        public static ModelModel MapModelEntity(Model model)
        {
            return new ModelModel
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
                BrandId = modelModel.Brand.Id,
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

        public static BrandModel MapBrandEntity(Brand brand)
        {
            return new BrandModel
            {
                Name = brand.Name,
                Id = brand.Id,
                ExteriorColors = brand.ExteriorColors.Select(MapExteriorColorEntity()).ToList(),
                InteriorColors = brand.InteriorColors.Select(MapInteriorColorEntity()).ToList()
            };
        }

        public static FuelTypeModel MapFuelTypeEntity(FuelType fuelType)
        {
            return new FuelTypeModel
            {
                Id = fuelType.Id,
                Code = fuelType.Code,
                Name = fuelType.Name
            };
        }

        public static DoorTypeModel MapDoorTypeEntity(DoorType doorType)
        {
            return new DoorTypeModel
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

        private static Func<InteriorColor, InteriorColorModel> MapInteriorColorEntity()
        {
            return ic => new InteriorColorModel
            {
                Id = ic.Id,
                BrandId = ic.BrandId,
                Code = ic.Code,
                Name = ic.Name
            };
        }

        private static Func<ExteriorColor, ExteriorColorModel> MapExteriorColorEntity()
        {
            return ec => new ExteriorColorModel
            {
                BrandId = ec.BrandId,
                Code = ec.Code,
                Id = ec.Id,
                Name = ec.Name
            };
        }
    }
}
