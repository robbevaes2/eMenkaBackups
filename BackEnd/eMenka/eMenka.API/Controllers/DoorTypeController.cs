using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.VehicleModels;
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

            return Ok(doorTypes.ToList().Select(VehicleMappers.MapDoorTypeEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetDoorTypesById(int id)
        {
            var doorType = _doorTypeRepository.GetById(id);
            if (doorType == null)
                return BadRequest();

            return Ok(VehicleMappers.MapDoorTypeEntity(doorType));
        }

        [HttpGet("{doorTypeName}")]
        public IActionResult GetDoorTypeByName(string doorTypeName)
        {
            var doorTypes = _doorTypeRepository.Find(doorType => doorType.Name == doorTypeName);
            if (doorTypes == null)
                return BadRequest();

            return Ok(doorTypes.ToList().Select(VehicleMappers.MapDoorTypeEntity));
        }

        [HttpPost]
        public IActionResult PostDoorType([FromBody] DoorTypeModel doorTypeModel)
        {
            _doorTypeRepository.Add(VehicleMappers.MapDoorTypeModel(doorTypeModel)); 
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoorType([FromBody] DoorTypeModel doorTypeModel, int id)
        {
            var isUpdated = _doorTypeRepository.Update(id, VehicleMappers.MapDoorTypeModel(doorTypeModel));

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
