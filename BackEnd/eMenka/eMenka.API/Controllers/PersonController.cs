using System.Linq;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : GenericController<Person, PersonModel, PersonReturnModel>
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository) : base(personRepository, new PersonMapper())
        {
            _personRepository = personRepository;
        }

        public override IActionResult PostEntity(PersonModel model)
        {
            Person person =  _personRepository.Find(p => p.DriversLicenseNumber == model.DriversLicenseNumber).FirstOrDefault();

            if (person != null)
            {
                return BadRequest($"Person with driverslicense {model.DriversLicenseNumber} already exists");
            }

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(PersonModel model, int id)
        {
            Person person = _personRepository.Find(p => p.DriversLicenseNumber == model.DriversLicenseNumber).FirstOrDefault();

            if (person != null && person.Id != model.Id)
            {
                return BadRequest($"Person with driverslicense {model.DriversLicenseNumber} already exists");
            }
            return base.UpdateEntity(model, id);
        }
    }
}