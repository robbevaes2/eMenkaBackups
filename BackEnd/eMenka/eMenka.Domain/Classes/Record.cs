using eMenka.Domain.Enums;
using System;

namespace eMenka.Domain.Classes
{
    public class Record
    {
        public int Id { get; set; }
        public FuelCard FuelCard { get; set; }
        public int? FuelCardId { get; set; }
        public Corporation Corporation { get; set; }
        public int? CorporationId { get; set; }
        public CostAllocation CostAllocation { get; set; }
        public int? CostAllocationId { get; set; }
        public Term Term { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Usage Usage { get; set; }
    }
}