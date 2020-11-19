using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Enums;

namespace eMenka.API.Models.RecordModels.ReturnModels
{
    public class RecordReturnModel
    {
        public int Id { get; set; }
        public FuelCardReturnModel FuelCard { get; set; }
        //public Corporation Corporation { get; set; }
        public int? Corporation { get; set; }
        //public CostAllocation CostAllocation { get; set; }
        public int? CostAllocation { get; set; }
        public Term Term { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Usage Usage { get; set; }
    }
}
