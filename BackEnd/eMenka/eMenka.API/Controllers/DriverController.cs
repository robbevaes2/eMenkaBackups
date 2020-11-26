using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Mappers.StaticMappers;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class DriverController : GenericController<Driver, DriverModel, DriverReturnModel>
    {
        private readonly IPersonRepository _personRepository;

        public DriverController(IDriverRepository driverRepository, IPersonRepository personRepository) : base(driverRepository, new DriverMapper())
        {
            _personRepository = personRepository;
        }

        public override IActionResult PostEntity(DriverModel model)
        {
            if (_personRepository.GetById((int)model.PersonId) == null)
                return NotFound($"Person with id {model.PersonId} not found");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(DriverModel model, int id)
        {
            if (_personRepository.GetById((int)model.PersonId) == null)
                return NotFound($"Person with id {model.PersonId} not found");

            return base.UpdateEntity(model, id);
        }
    }
}