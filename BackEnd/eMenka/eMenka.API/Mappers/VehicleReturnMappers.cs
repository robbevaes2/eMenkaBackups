using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.VehicleModels;
using eMenka.API.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers
{
    public static class VehicleReturnMappers
    {
        public static VehicleReturnModel MapVehicleEntity(Vehicle vehicle)
        {
            return new VehicleReturnModel
            {
                Id = vehicle.Id,
                BrandReturn = MapBrandEntity(vehicle.Brand),
                FuelTypeReturn = MapFuelTypeEntity(vehicle.FuelType),
                MotorTypeReturn = MapMotorTypeEntity(vehicle.MotorType),
                DoorTypeReturn = MapDoorTypeEntity(vehicle.DoorType), 
                Emission = vehicle.Emission,
                EndDate = vehicle.EndDate,
                FiscalePk = vehicle.FiscalePk,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                ModelReturn = MapModelEntity(vehicle.Model),
                FuelCard = vehicle.FuelCard.Id 
            };
        }

        public static Vehicle MapVehicleModel(VehicleReturnModel vehicleReturnModel)
        {
            return new Vehicle
            {
                Id = vehicleReturnModel.Id,
                MotorTypeId = vehicleReturnModel.MotorTypeReturn.Id,
                BrandId = vehicleReturnModel.BrandReturn.Id,
                DoorTypeId = vehicleReturnModel.DoorTypeReturn.Id,
                Emission = vehicleReturnModel.Emission,
                EndDate = vehicleReturnModel.EndDate,
                FiscalePk = vehicleReturnModel.FiscalePk,
                FuelTypeId = vehicleReturnModel.FuelTypeReturn.Id, 
                IsActive = vehicleReturnModel.IsActive,
                ModelId = vehicleReturnModel.ModelReturn.Id,
                Power = vehicleReturnModel.Power,
                Volume = vehicleReturnModel.Volume,
                FuelCardId = vehicleReturnModel.FuelCard//.Id 
            };
        }

        public static SerieReturnModel MapSerieEntity(Serie serie)
        {
            return new SerieReturnModel
            {
                BrandReturn = MapBrandEntity(serie.Brand),
                Name = serie.Name,
                Id = serie.Id
            };
        }
        public static Serie MapSerieModel(SerieReturnModel serieReturnModel)
        {
            return new Serie
            {
                BrandId = serieReturnModel.BrandReturn.Id,
                Id = serieReturnModel.Id,
                Name = serieReturnModel.Name
            };
        }

        public static MotorTypeReturnModel MapMotorTypeEntity(MotorType motorType)
        {
            return new MotorTypeReturnModel
            {
                BrandReturn = MapBrandEntity(motorType.Brand),
                Name = motorType.Name,
                Id = motorType.Id
            };
        }
        public static MotorType MapMotorTypeModel(MotorTypeReturnModel motorTypeReturnModel)
        {
            return new MotorType
            {
                BrandId = motorTypeReturnModel.BrandReturn.Id,
                Id = motorTypeReturnModel.Id,
                Name = motorTypeReturnModel.Name
            };
        }

        public static ModelReturnModel MapModelEntity(Model model)
        {
            return new ModelReturnModel
            {
                BrandReturn = MapBrandEntity(model.Brand),
                Name = model.Name,
                Id = model.Id
            };
        }
        public static Model MapModelModel(ModelReturnModel modelReturnModel)
        {
            return new Model
            {
                BrandId = modelReturnModel.BrandReturn.Id,
                Id = modelReturnModel.Id,
                Name = modelReturnModel.Name
            };
        }

        public static Brand MapBrandModel(BrandReturnModel brandReturnModel)
        {
            return new Brand
            {
                Id = brandReturnModel.Id,
                Name = brandReturnModel.Name
            };
        }

        public static BrandReturnModel MapBrandEntity(Brand brand)
        {
            return new BrandReturnModel
            {
                Name = brand.Name,
                Id = brand.Id,
                ExteriorColors = brand.ExteriorColors.Select(MapExteriorColorEntity()).ToList(),
                InteriorColors = brand.InteriorColors.Select(MapInteriorColorEntity()).ToList()
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

        public static FuelType MapFuelTypeModel(FuelTypeReturnModel fuelTypeReturnModel)
        {
            return new FuelType
            {
                Code = fuelTypeReturnModel.Code,
                Id = fuelTypeReturnModel.Id,
                Name = fuelTypeReturnModel.Name
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

        public static DoorType MapDoorTypeModel(DoorTypeReturnModel doorTypeReturnModel)
        {
            return new DoorType
            {
                Id = doorTypeReturnModel.Id,
                Name = doorTypeReturnModel.Name
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
