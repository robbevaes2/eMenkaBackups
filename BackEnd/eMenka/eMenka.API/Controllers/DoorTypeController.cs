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
    public class DoorTypeController : ControllerBase
    {
        private readonly IDoorTypeRepository _doorTypeRepository;

        public DoorTypeController(IDoorTypeRepository doorTypeRepository)
        {
            _doorTypeRepository = doorTypeRepository;
        }


        [HttpGet]
        public IActionResult GetAllDoorTypes()
        {
            var doorTypes = _doorTypeRepository.GetAll();
            if (doorTypes == null)
                return BadRequest();

            return Ok(doorTypes.ToList().Select(VehicleReturnMappers.MapDoorTypeEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetDoorTypesById(int id)
        {
            var doorType = _doorTypeRepository.GetById(id);
            if (doorType == null)
                return BadRequest();

            return Ok(VehicleReturnMappers.MapDoorTypeEntity(doorType));
        }

        [HttpGet("{doorTypeName}")]
        public IActionResult GetDoorTypeByName(string doorTypeName)
        {
            var doorTypes = _doorTypeRepository.Find(doorType => doorType.Name == doorTypeName);
            if (doorTypes == null)
                return BadRequest();

            return Ok(doorTypes.ToList().Select(VehicleReturnMappers.MapDoorTypeEntity));
        }

        [HttpPost]
        public IActionResult PostDoorType([FromBody] DoorTypeReturnModel doorTypeReturnModel)
        {
            _doorTypeRepository.Add(VehicleReturnMappers.MapDoorTypeModel(doorTypeReturnModel)); 
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoorType([FromBody] DoorTypeReturnModel doorTypeReturnModel, int id)
        {
            var isUpdated = _doorTypeRepository.Update(id, VehicleReturnMappers.MapDoorTypeModel(doorTypeReturnModel));

            if (!isUpdated)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoorType(int id)
        {
            var doorType = _doorTypeRepository.GetById(id);
            if (doorType == null)
                return BadRequest();

            _doorTypeRepository.Remove(doorType);
            return Ok();
        }
    }
}
