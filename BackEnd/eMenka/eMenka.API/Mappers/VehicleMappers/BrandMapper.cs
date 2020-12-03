using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;
using System.Linq;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class BrandMapper : IMapper<Brand, BrandModel, BrandReturnModel>
    {
        private readonly ExteriorColorMapper _exteriorColorMapper;
        private readonly InteriorColorMapper _interiorColorMapper;

        public BrandMapper()
        {
            _interiorColorMapper = new InteriorColorMapper();
            _exteriorColorMapper = new ExteriorColorMapper();
        }

        public BrandReturnModel MapEntityToReturnModel(Brand entity)
        {
            if (entity == null)
                return null;
            return new BrandReturnModel
            {
                Name = entity.Name,
                Id = entity.Id,
                ExteriorColors = entity.ExteriorColors.Select(_exteriorColorMapper.MapExteriorColorEntity).ToList(),
                InteriorColors = entity.InteriorColors.Select(_interiorColorMapper.MapInteriorColorEntity).ToList()
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
    }
}