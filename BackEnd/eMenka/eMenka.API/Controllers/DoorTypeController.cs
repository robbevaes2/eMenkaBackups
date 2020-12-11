using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutoMapper;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class DoorTypeController : GenericController<DoorType, DoorTypeModel, DoorTypeReturnModel>
    {
        private readonly IDoorTypeRepository _doorTypeRepository;
        private readonly IMapper _mapper;

        public DoorTypeController(IDoorTypeRepository doorTypeRepository, IMapper mapper) : base(doorTypeRepository,
            mapper)
        {
            _doorTypeRepository = doorTypeRepository;
            _mapper = mapper;
        }

        [HttpGet("name/{doorTypeName}")]
        public IActionResult GetDoorTypeByName(string doorTypeName)
        {
            var doorTypes = _doorTypeRepository.Find(doorType => doorType.Name == doorTypeName);

            return Ok(doorTypes.Select(_mapper.Map<DoorTypeReturnModel>).ToList());
        }
    }
}