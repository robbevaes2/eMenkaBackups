using eMenka.API.Models.SupplierModels;
using eMenka.API.Models.SupplierModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.SupplierMappers
{
    public class SupplierMapper : IMapper<Supplier, SupplierModel, SupplierReturnModel>
    {
        public SupplierReturnModel MapEntityToReturnModel(Supplier entity)
        {
            if (entity == null)
                return null;

            return new SupplierReturnModel
            {
                Name = entity.Name,
                Active = entity.Active,
                Id = entity.Id,
                Internal = entity.Internal,
                Types = entity.Types
            };
        }

        public Supplier MapModelToEntity(SupplierModel model)
        {
            return new Supplier
            {
                Name = model.Name,
                Active = model.Active,
                Id = model.Id,
                Internal = model.Internal,
                Types = model.Types
            };
        }
    }
}
