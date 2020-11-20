using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.Models.FuelCardModels
{
    public class DriverModel
    {
        public int Id { get; set; }
        [Required]
        public int? PersonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
