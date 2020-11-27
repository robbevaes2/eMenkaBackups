using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class DoorTypeMapper : IMapper<DoorType, DoorTypeModel, DoorTypeReturnModel>
    {
        public DoorTypeReturnModel MapEntityToReturnModel(DoorType entity)
        {
            if (entity == null)
                return null;
            return new DoorTypeReturnModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public DoorType MapModelToEntity(DoorTypeModel model)
        {
            return new DoorType
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
