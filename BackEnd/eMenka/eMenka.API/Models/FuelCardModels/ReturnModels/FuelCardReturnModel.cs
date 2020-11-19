using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.Models.FuelCardModels.ReturnModels
{
    public class FuelCardReturnModel
    {
        public int Id { get; set; }
        public DriverReturnModel Driver { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Active { get; set; }
    }
}
