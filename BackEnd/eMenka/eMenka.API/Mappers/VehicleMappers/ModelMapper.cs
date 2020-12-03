using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class ModelMapper : IMapper<Model, ModelModel, ModelReturnModel>
    {
        private readonly BrandMapper _brandMapper;

        public ModelMapper()
        {
            _brandMapper = new BrandMapper();
        }

        public ModelReturnModel MapEntityToReturnModel(Model entity)
        {
            if (entity == null)
                return null;
            return new ModelReturnModel
            {
                Brand = _brandMapper.MapEntityToReturnModel(entity.Brand),
                Name = entity.Name,
                Id = entity.Id
            };
        }

        public Model MapModelToEntity(ModelModel model)
        {
            return new Model
            {
                BrandId = (int)model.BrandId,
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}