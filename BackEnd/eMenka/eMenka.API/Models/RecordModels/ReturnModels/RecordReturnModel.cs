using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Enums;
using System;

namespace eMenka.API.Models.RecordModels.ReturnModels
{
    public class RecordReturnModel
    {
        public int Id { get; set; }
        public FuelCardReturnModel FuelCard { get; set; }
        public CorporationReturnModel Corporation { get; set; }
        public CostAllocationReturnModel CostAllocation { get; set; }
        public Term Term { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Usage Usage { get; set; }
    }
}