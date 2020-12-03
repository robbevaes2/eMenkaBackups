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
        public PersonController(IPersonRepository personRepository) : base(personRepository, new PersonMapper())
        {
        }
    }
}