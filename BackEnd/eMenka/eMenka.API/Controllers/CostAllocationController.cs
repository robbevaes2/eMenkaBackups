﻿using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    public class
        CostAllocationController : GenericController<CostAllocation, CostAllocationModel, CostAllocationReturnModel>
    {
        public CostAllocationController(ICostAllocationRepository costAllocationRepository) : base(
            costAllocationRepository, new CostAllocationMapper())
        {
        }
    }
}