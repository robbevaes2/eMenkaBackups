using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.VehicleModels;
using eMenka.API.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class FuelTypeController : ControllerBase
    {
        private readonly IFuelTypeRepository _fuelTypeRepository;

        public FuelTypeController(IFuelTypeRepository fuelTypeRepository)
        {
            _fuelTypeRepository = fuelTypeRepository;
        }

        [HttpGet]
        public IActionResult GetAllFuelTypes()
        {
            var fuelTypes = _fuelTypeRepository.GetAll();
            if (fuelTypes == null)
                return BadRequest();

            return Ok(fuelTypes.ToList().Select(VehicleReturnMappers.MapFuelTypeEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetFuelTypesById(int id)
        {
            var fuelType = _fuelTypeRepository.GetById(id);
            if (fuelType == null)
                return BadRequest();

            return Ok(VehicleReturnMappers.MapFuelTypeEntity(fuelType));
        }

        [HttpPost]
        public IActionResult PostFuelType([FromBody] FuelTypeReturnModel fuelTypeReturnModel)
        {
            _fuelTypeRepository.Add(VehicleReturnMappers.MapFuelTypeModel(fuelTypeReturnModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFuelType([FromBody] FuelTypeReturnModel fuelTypeReturnModel, int id)
        {
            var isUpdated = _fuelTypeRepository.Update(id, VehicleReturnMappers.MapFuelTypeModel(fuelTypeReturnModel));

            if (!isUpdated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFuelType(int id)
        {
            var fuelType = _fuelTypeRepository.GetById(id);
            if (fuelType == null)
                return BadRequest();

            _fuelTypeRepository.Remove(fuelType);
            return Ok();
        }
    }
}
