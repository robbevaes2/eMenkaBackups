using eMenka.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.FuelCardModels
{
    public class PersonModel : IModelBase
    {
        [Required] public string Firstname { get; set; }

        [Required] public string Lastname { get; set; }

        public DateTime? BirthDate { get; set; }
        public Language Language { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string DriversLicenseType { get; set; }
        public DateTime? StartDateDriversLicense { get; set; }
        public DateTime? EndDateDriversLicense { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public byte[] Picture { get; set; }
        public int Id { get; set; }
    }
}