using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class SerieMapper : IMapper<Series, SerieModel, SerieReturnModel>
    {
        private readonly BrandMapper _brandMapper;

        public SerieMapper()
        {
            _brandMapper = new BrandMapper();
        }

        public SerieReturnModel MapEntityToReturnModel(Series entity)
        {
            if (entity == null)
                return null;
            return new SerieReturnModel
            {
                Brand = _brandMapper.MapEntityToReturnModel(entity.Brand),
                Name = entity.Name,
                Id = entity.Id
            };
        }

        public Series MapModelToEntity(SerieModel model)
        {
            return new Series
            {
                BrandId = (int)model.BrandId,
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}