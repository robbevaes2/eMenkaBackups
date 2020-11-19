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
        [Required]
        public int? FuelCardId { get; set; } 
        [Required]
        public int? Volume { get; set; }
        [Required]
        public int? FiscalHp { get; set; }
        [Required]
        public int? Emission { get; set; }
        [Required]
        public int? Power { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int? CategoryId { get; set; }

        public string LicensePlate { get; set; }
        public string Chassis { get; set; }
        public int? EngineCapacity { get; set; }
        public int EnginePower { get; set; }
        public DateTime? EndDateDelivery { get; set; }
        public int? AverageFuel { get; set; }
    }
}
