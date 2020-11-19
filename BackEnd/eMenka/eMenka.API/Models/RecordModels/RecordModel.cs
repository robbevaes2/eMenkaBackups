using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eMenka.Domain.Enums;

namespace eMenka.API.Models.RecordModels
{
    public class RecordModel
    {
        public int Id { get; set; }
        public int? FuelCardId { get; set; }
        [Required]
        public int? CompanyId { get; set; }
        public string City { get; set; }
        public Term Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Usage Usage { get; set; }
    }
}
