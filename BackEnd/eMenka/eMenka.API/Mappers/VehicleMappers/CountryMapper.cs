using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class CountryMapper : IMapper<Country, CountryModel, CountryReturnModel>
    {
        public CountryReturnModel MapEntityToReturnModel(Country entity)
        {
            if (entity == null)
                return null;
            return new CountryReturnModel
            {
                Code = entity.Code,
                Id = entity.Id,
                IsActive = entity.IsActive,
                Name = entity.Name,
                Nationality = entity.Nationality,
                POD = entity.POD
            };
        }

        public Country MapModelToEntity(CountryModel model)
        {
            return new Country
            {
                POD = model.POD,
                Code = model.Code,
                Id = model.Id,
                IsActive = model.IsActive,
                Name = model.Name,
                Nationality = model.Nationality
            };
        }
    }
}