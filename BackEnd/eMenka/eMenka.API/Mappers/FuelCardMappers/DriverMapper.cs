using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.FuelCardMappers
{
    public class DriverMapper : IMapper<Driver, DriverModel, DriverReturnModel>
    {
        private PersonMapper _personMapper;

        public DriverMapper()
        {
            _personMapper = new PersonMapper();
        }
        public DriverReturnModel MapEntityToReturnModel(Driver entity)
        {
            if (entity == null)
                return null;
            return new DriverReturnModel
            {
                EndDate = entity.EndDate,
                StartDate = entity.StartDate,
                Id = entity.Id,
                Person = _personMapper.MapEntityToReturnModel(entity.Person)
            };
        }

        public Driver MapModelToEntity(DriverModel model)
        {
            return new Driver
            {
                Id = model.Id,
                EndDate = model.EndDate,
                PersonId = (int)model.PersonId,
                StartDate = model.StartDate
            };
        }
    }
}
