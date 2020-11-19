using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult GetAllPersons()
        {
            var persons = _personRepository.GetAll();

            return Ok(persons.ToList().Select(FuelCardMappers.MapPersonEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetPersonById(int id)
        {
            var person = _personRepository.GetById(id);
            if (person == null)
                return NotFound();

            return Ok(FuelCardMappers.MapPersonEntity(person));
        }

        [HttpPost]
        public IActionResult PostPerson([FromBody] PersonModel personModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _personRepository.Add(FuelCardMappers.MapPersonModel(personModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePerson([FromBody] PersonModel personModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != personModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _personRepository.Update(id, FuelCardMappers.MapPersonModel(personModel));

            if (!isUpdated)
                return NotFound($"No Person found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            var person = _personRepository.GetById(id);
            if (person == null)
                return NotFound();

            _personRepository.Remove(person);
            return Ok();
        }
    }
}
