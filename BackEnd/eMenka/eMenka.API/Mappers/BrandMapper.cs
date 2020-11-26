using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers
{
    public class BrandMapper : IMapper<Brand, BrandModel, BrandReturnModel>
    {
        public BrandReturnModel MapEntityToReturnModel(Brand entity)
        {
            if (entity == null)
                return null;
            return new BrandReturnModel
            {
                Name = entity.Name,
                Id = entity.Id,
                ExteriorColors = entity.ExteriorColors.Select(MapExteriorColorEntity).ToList(),
                InteriorColors = entity.InteriorColors.Select(MapInteriorColorEntity).ToList()
            };
        }

        public Brand MapModelToEntity(BrandModel model)
        {
            return new Brand
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public static InteriorColorReturnModel MapInteriorColorEntity(InteriorColor interiorColor)
        {
            return new InteriorColorReturnModel
            {
                Id = interiorColor.Id,
                Code = interiorColor.Code,
                Name = interiorColor.Name
            };
        }

        public static ExteriorColorReturnModel MapExteriorColorEntity(ExteriorColor exteriorColor)
        {
            return new ExteriorColorReturnModel
            {
                Code = exteriorColor.Code,
                Id = exteriorColor.Id,
                Name = exteriorColor.Name
            };
        }
    }
}
