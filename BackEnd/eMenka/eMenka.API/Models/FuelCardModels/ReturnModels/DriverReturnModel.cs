using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.Models.FuelCardModels.ReturnModels
{
    public class DriverReturnModel
    {
        public int Id { get; set; }
        public PersonReturnModel Person { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
