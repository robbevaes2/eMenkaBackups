using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class FuelTypeMapper : IMapper<FuelType, FuelTypeModel, FuelTypeReturnModel>
    {
        public FuelTypeReturnModel MapEntityToReturnModel(FuelType entity)
        {
            if (entity == null)
                return null;
            return new FuelTypeReturnModel
            {
                Id = entity.Id,
                Code = entity.Code,
                Name = entity.Name
            };
        }

        public FuelType MapModelToEntity(FuelTypeModel model)
        {
            return new FuelType
            {
                Code = model.Code,
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
