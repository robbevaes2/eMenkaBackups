using System.Linq;
using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Cors;
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
    }
}