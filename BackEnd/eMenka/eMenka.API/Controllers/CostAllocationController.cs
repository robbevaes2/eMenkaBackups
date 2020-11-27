using eMenka.API.Mappers;
using eMenka.API.Models.RecordModels;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class CostAllocationController : GenericController<CostAllocation, CostAllocationModel, CostAllocationReturnModel>
    {

        public CostAllocationController(ICostAllocationRepository costAllocationRepository) : base(costAllocationRepository, new CostAllocationMapper())
        {
        }
    }
}