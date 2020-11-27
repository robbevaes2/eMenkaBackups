using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.RecordMappers
{
    public class RecordMapper : IMapper<Record, RecordModel, RecordReturnModel>
    {
        private FuelCardMapper _fuelCardMapper;
        private CorporationMapper _coporationMapper;
        private CostAllocationMapper _costAllocationMapper;

        public RecordMapper()
        {
            _fuelCardMapper = new FuelCardMapper();
            _coporationMapper = new CorporationMapper();
            _costAllocationMapper = new CostAllocationMapper();
        }
        public RecordReturnModel MapEntityToReturnModel(Record entity)
        {
            if (entity == null)
                return null;
            return new RecordReturnModel
            {
                FuelCard = _fuelCardMapper.MapEntityToReturnModel(entity.FuelCard),
                Id = entity.Id,
                Term = entity.Term,
                Usage = entity.Usage,
                EndDate = entity.EndDate,
                StartDate = entity.StartDate,
                Corporation = _coporationMapper.MapEntityToReturnModel(entity.Corporation),
                CostAllocation = _costAllocationMapper.MapEntityToReturnModel(entity.CostAllocation)
            };
        }

        public Record MapModelToEntity(RecordModel model)
        {
            return new Record
            {
                Usage = model.Usage,
                CorporationId = model.CorporationId,
                CostAllocationId = model.CostAllocationId,
                EndDate = model.EndDate,
                FuelCardId = (int)model.FuelCardId,
                Id = model.Id,
                StartDate = model.StartDate,
                Term = model.Term
            };
        }
    }
}
