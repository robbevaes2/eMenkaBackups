using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.Models.RecordModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CostAllocationController : ControllerBase
    {
        private readonly ICostAllocationRepository _costAllocationRepository;

        public CostAllocationController(ICostAllocationRepository costAllocationRepository)
        {
            _costAllocationRepository = costAllocationRepository;
        }

        [HttpGet]
        public IActionResult GetAllCostAllocations()
        {
            var costAllocations = _costAllocationRepository.GetAll();

            return Ok(costAllocations.ToList().Select(RecordMappers.MapCostAllocationEntity).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCostAllocationById(int id)
        {
            var costAllocation = _costAllocationRepository.GetById(id);
            if (costAllocation == null)
                return NotFound();

            return Ok(RecordMappers.MapCostAllocationEntity(costAllocation));
        }

        [HttpPost]
        public IActionResult PostCostAllocation([FromBody] CostAllocationModel costAllocationModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _costAllocationRepository.Add(RecordMappers.MapCostAllocationModel(costAllocationModel));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCostAllocation([FromBody] CostAllocationModel costAllocationModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != costAllocationModel.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _costAllocationRepository.Update(id, RecordMappers.MapCostAllocationModel(costAllocationModel));

            if (!isUpdated)
                return NotFound($"No Cost allocation found with id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCostAllocation(int id)
        {
            var costAllocation = _costAllocationRepository.GetById(id);
            if (costAllocation == null)
                return NotFound();

            _costAllocationRepository.Remove(costAllocation);
            return Ok();
        }
    }
}
