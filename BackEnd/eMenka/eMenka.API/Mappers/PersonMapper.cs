using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers
{
    public class PersonMapper : IMapper<Person, PersonModel, PersonReturnModel>
    {
        public PersonReturnModel MapEntityToReturnModel(Person entity)
        {
            if (entity == null)
                return null;
            return new PersonReturnModel
            {
                Title = entity.Title,
                BirthDate = entity.BirthDate,
                StartDateDriversLicense = entity.StartDateDriversLicense,
                Picture = entity.Picture,
                Lastname = entity.Lastname,
                Language = entity.Language,
                Id = entity.Id,
                Gender = entity.Gender,
                Firstname = entity.Firstname,
                EndDateDriversLicense = entity.EndDateDriversLicense,
                DriversLicenseNumber = entity.DriversLicenseNumber,
                DriversLicenseType = entity.DriversLicenseType
            };
        }

        public Person MapModelToEntity(PersonModel model)
        {
            return new Person
            {
                BirthDate = model.BirthDate,
                DriversLicenseNumber = model.DriversLicenseNumber,
                DriversLicenseType = model.DriversLicenseType,
                EndDateDriversLicense = model.EndDateDriversLicense,
                Firstname = model.Firstname,
                Gender = model.Gender,
                Id = model.Id,
                Language = model.Language,
                Lastname = model.Lastname,
                Picture = model.Picture,
                StartDateDriversLicense = model.StartDateDriversLicense,
                Title = model.Title
            };
        }
    }
}
