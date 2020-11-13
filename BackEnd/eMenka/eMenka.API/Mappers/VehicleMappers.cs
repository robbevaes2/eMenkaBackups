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
            return new VehicleReturnModel
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
                MotorTypeId = (int) vehicleModel.MotorTypeId,
                BrandId = (int) (int)vehicleModel.BrandId,
                DoorTypeId = (int)vehicleModel.DoorTypeId,
                Emission = (int)vehicleModel.Emission,
                EndDate = vehicleModel.EndDate,
                FiscalePk = (int)vehicleModel.FiscalePk,
                FuelTypeId = (int)vehicleModel.FuelTypeId, 
                IsActive = vehicleModel.IsActive,
                ModelId = (int)vehicleModel.ModelId,
                Power = (int)vehicleModel.Power,
                Volume = (int)vehicleModel.Volume,
                FuelCardId = vehicleModel.FuelCard//.Id 
            };
        }

        public static SerieReturnModel MapSerieEntity(Serie serie)
        {
            return new SerieReturnModel
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
                BrandId = (int)serieModel.BrandId,
                Id = serieModel.Id,
                Name = serieModel.Name
            };
        }

        public static MotorTypeReturnModel MapMotorTypeEntity(MotorType motorType)
        {
            return new MotorTypeReturnModel
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
                BrandId = (int)motorTypeModel.BrandId,
                Id = motorTypeModel.Id,
                Name = motorTypeModel.Name
            };
        }

        public static ModelReturnModel MapModelEntity(Model model)
        {
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
        }
    }
}
