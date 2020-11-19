using System;
using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class VehicleModel
    {
        public int Id { get; set; }
        [Required]
        public int? BrandId { get; set; }
        [Required]
        public int? ModelId { get; set; }
        [Required]
        public int? FuelTypeId { get; set; }
        [Required]
        public int? EngineTypeId { get; set; }
        [Required]
        public int? DoorTypeId { get; set; }
        public int FuelCard { get; set; } //todo refactor to FuelCardModel
        [Required]
        public int? Volume { get; set; }
        [Required]
        public int? FiscalePk { get; set; }
        [Required]
        public int? Emission { get; set; }
        [Required]
        public int? Power { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM:yyyy}")]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int? CategoryId { get; set; }

        public string LicensePlate { get; set; }
    }
}
