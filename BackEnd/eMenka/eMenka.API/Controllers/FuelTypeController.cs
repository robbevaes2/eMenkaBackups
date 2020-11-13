using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
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

            return Ok(fuelTypes.ToList().Select(VehicleMappers.MapFuelTypeEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetFuelTypesById(int id)
        {
            var fuelType = _fuelTypeRepository.GetById(id);
            if (fuelType == null)
                return BadRequest();

            return Ok(VehicleMappers.MapFuelTypeEntity(fuelType));
        }

        [HttpPost]
        public IActionResult PostFuelType([FromBody] FuelTypeModel fuelTypeModel)
        {
            _fuelTypeRepository.Add(VehicleMappers.MapFuelTypeModel(fuelTypeModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFuelType([FromBody] FuelTypeModel fuelTypeModel, int id)
        {
            if(id != fuelTypeModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _fuelTypeRepository.Update(id, VehicleMappers.MapFuelTypeModel(fuelTypeModel));

            if (!isUpdated)
                return BadRequest("Update failed");

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
