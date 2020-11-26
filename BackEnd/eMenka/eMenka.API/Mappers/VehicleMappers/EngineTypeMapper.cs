﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class EngineTypeMapper : IMapper<EngineType, EngineTypeModel, EngineTypeReturnModel>
    {
        private BrandMapper _brandMapper;
        public EngineTypeMapper()
        {
            _brandMapper = new BrandMapper();
        }

        public EngineTypeReturnModel MapEntityToReturnModel(EngineType entity)
        {
            if (entity == null)
                return null;
            return new EngineTypeReturnModel
            {
                Brand = _brandMapper.MapEntityToReturnModel(entity.Brand),
                Name = entity.Name,
                Id = entity.Id
            };
        }

        public EngineType MapModelToEntity(EngineTypeModel model)
        {
            return new EngineType
            {
                BrandId = (int)model.BrandId,
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}