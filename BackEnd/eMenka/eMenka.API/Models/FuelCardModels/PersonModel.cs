using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eMenka.Domain.Enums;

namespace eMenka.API.Models.FuelCardModels
{
    public class PersonModel
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public DateTime? BirthDate { get; set; }
        public Language Language { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string DriversLicenseType { get; set; }
        public DateTime? StartDateDriversLicense { get; set; }
        public DateTime? EndDateDriversLicense { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public byte[] Picture { get; set; }
    }
}
