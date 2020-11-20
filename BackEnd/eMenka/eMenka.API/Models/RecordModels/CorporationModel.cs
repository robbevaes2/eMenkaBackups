using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.Models.RecordModels
{
    public class CorporationModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        [Required]
        public int? CompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
