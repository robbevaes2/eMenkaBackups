using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.RecordMappers
{
    public class CostAllocationMapper : IMapper<CostAllocation, CostAllocationModel, CostAllocationReturnModel>
    {
        public CostAllocationReturnModel MapEntityToReturnModel(CostAllocation entity)
        {
            if (entity == null)
                return null;
            return new CostAllocationReturnModel
            {
                Abbreviation = entity.Abbreviation,
                EndDate = entity.EndDate,
                Id = entity.Id,
                Name = entity.Name,
                StartDate = entity.StartDate
            };
        }

        public CostAllocation MapModelToEntity(CostAllocationModel model)
        {
            return new CostAllocation
            {
                Abbreviation = model.Abbreviation,
                Id = model.Id,
                Name = model.Name,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };
        }
    }
}