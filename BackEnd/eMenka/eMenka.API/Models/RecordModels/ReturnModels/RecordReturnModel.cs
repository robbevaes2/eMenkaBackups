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
        public CompanyReturnModel Company { get; set; } 
        public string City { get; set; }
        public Term Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Usage Usage { get; set; }
    }
}
