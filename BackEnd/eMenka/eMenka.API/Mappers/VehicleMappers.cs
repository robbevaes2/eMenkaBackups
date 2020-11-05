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
                BrandId = vehicle.Brand.Id,
                FuelTypeId = vehicle.FuelTypeId,
                MotorTypeId = vehicle.MotorType.Id,
                DoorTypeId = vehicle.DoorTypeId,
                Emission = vehicle.Emission,
                EndDate = vehicle.EndDate,
                FiscalePk = vehicle.FiscalePk,
                IsActive = vehicle.IsActive,
                Power = vehicle.Power,
                Volume = vehicle.Volume,
                ModelId = vehicle.Id,
                FuelCardId = vehicle.FuelCardId
            };
        }

        public static Vehicle MapVehicleModel(VehicleModel vehicleModel)
        {
            return new Vehicle
            {
                Id = vehicleModel.Id,
                MotorTypeId = vehicleModel.MotorTypeId,
                BrandId = vehicleModel.BrandId,
                DoorTypeId = vehicleModel.DoorTypeId,
                Emission = vehicleModel.Emission,
                EndDate = vehicleModel.EndDate,
                FiscalePk = vehicleModel.FiscalePk,
                FuelTypeId = vehicleModel.FuelTypeId,
                IsActive = vehicleModel.IsActive,
                ModelId = vehicleModel.ModelId,
                Power = vehicleModel.Power,
                Volume = vehicleModel.Volume,
                FuelCardId = vehicleModel.FuelCardId
            };
        }

        public static SerieModel MapSerieEntity(Serie serie)
        {
            return new SerieModel
            {
                BrandId = serie.BrandId,
                Name = serie.Name,
                Id = serie.Id
            };
        }
        public static Serie MapSerieModel(SerieModel serieModel)
        {
            return new Serie
            {
                BrandId = serieModel.BrandId,
                Id = serieModel.Id,
                Name = serieModel.Name
            };
        }

        public static MotorTypeModel MapMotorTypeEntity(MotorType motorType)
        {
            return new MotorTypeModel
            {
                BrandId = motorType.BrandId,
                Name = motorType.Name,
                Id = motorType.Id
            };
        }
        public static MotorType MapMotorTypeModel(MotorTypeModel motorTypeModel)
        {
            return new MotorType
            {
                BrandId = motorTypeModel.BrandId,
                Id = motorTypeModel.Id,
                Name = motorTypeModel.Name
            };
        }

        public static ModelModel MapModelEntity(Model model)
        {
            return new ModelModel
            {
                BrandId = model.BrandId,
                Name = model.Name,
                Id = model.Id
            };
        }
        public static Model MapModelModel(ModelModel modelModel)
        {
            return new Model
            {
                BrandId = modelModel.BrandId,
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
