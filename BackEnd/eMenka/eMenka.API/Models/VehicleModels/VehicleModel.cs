using System;
using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class VehicleModel : IModelBase
    {
        [Required] public int? BrandId { get; set; }
        [Required] public int? ModelId { get; set; }
        [Required] public int? FuelTypeId { get; set; }
        [Required] public int? EngineTypeId { get; set; }
        [Required] public int? DoorTypeId { get; set; }
        public int? FuelCardId { get; set; }
        [Required] public int? SeriesId { get; set; }
        [Required] public int? Volume { get; set; }
        [Required] public int? FiscalHP { get; set; }
        [Required] public int? Emission { get; set; }
        [Required] public bool IsActive { get; set; }
        [Required] public int? CategoryId { get; set; }
        [Required] public string LicensePlate { get; set; }
        [Required] public string Chassis { get; set; }
        public int? EngineCapacity { get; set; }
        public int EnginePower { get; set; }
        public DateTime? EndDateDelivery { get; set; }
        public int? AverageFuel { get; set; }
        public int? CountryId { get; set; }
        public int? BuildYear { get; set; }
        public double Kilometers { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int ExteriorColorId { get; set; }
        public int InteriorColorId { get; set; }
        public int Id { get; set; }
    }
}