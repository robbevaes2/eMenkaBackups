using System;
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
    public class DriverController : GenericController<Driver, DriverModel, DriverReturnModel>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IDriverRepository _driverRepository;
        private readonly DriverMapper _driverMapper;

        public DriverController(IDriverRepository driverRepository, IPersonRepository personRepository) : base(
            driverRepository, new DriverMapper())
        {
            _personRepository = personRepository;
            _driverRepository = driverRepository;
            _driverMapper = new DriverMapper();
        }

        [HttpGet("available")]
        public IActionResult GetAllAvailableDrivers()
        {
            var entities = _driverRepository.GetAllAvailableDrivers();
            return Ok(entities.Select(_driverMapper.MapEntityToReturnModel));
        }

        [HttpGet("enddate/{range}")]
        public IActionResult GetDriverByEndDate(int range)
        {
            var drivers = _driverRepository.Find(v => v.EndDate >= DateTime.Now.Date && v.EndDate <= DateTime.Now.Date.AddDays(range));

            return Ok(drivers.Select(_driverMapper.MapEntityToReturnModel).ToList());
        }

        public override IActionResult PostEntity(DriverModel model)
        {
            if (_personRepository.GetById((int)model.PersonId) == null)
                return NotFound($"Persoon met id {model.PersonId} niet gevonden");

            return base.PostEntity(model);
        }

        public override IActionResult UpdateEntity(DriverModel model, int id)
        {
            if (_personRepository.GetById((int)model.PersonId) == null)
                return NotFound($"Persoon met id {model.PersonId} niet gevonden");

            return base.UpdateEntity(model, id);
        }
    }
}