﻿using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.StaticMappers;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class DoorTypeController : GenericController<DoorType, DoorTypeModel, DoorTypeReturnModel>
    {
        private readonly IDoorTypeRepository _doorTypeRepository;
        private DoorTypeMapper _doortypeMapper;

        public DoorTypeController(IDoorTypeRepository doorTypeRepository) : base(doorTypeRepository, new DoorTypeMapper())
        {
            _doorTypeRepository = doorTypeRepository;
            _doortypeMapper = new DoorTypeMapper();
        }

        [HttpGet("name/{doorTypeName}")]
        public IActionResult GetDoorTypeByName(string doorTypeName)
        {
            var doorTypes = _doorTypeRepository.Find(doorType => doorType.Name == doorTypeName);

            return Ok(doorTypes.Select(_doortypeMapper.MapEntityToReturnModel).ToList());
        }
    }
}