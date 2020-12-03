using System;

namespace eMenka.Domain.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public Brand Brand { get; set; }
        public int? BrandId { get; set; }
        public Model Model { get; set; }
        public int? ModelId { get; set; }
        public Series Series { get; set; }
        public int? SeriesId { get; set; }
        public EngineType EngineType { get; set; }
        public int? EngineTypeId { get; set; }
        public FuelCard FuelCard { get; set; }
        public int? FuelCardId { get; set; }
        public DoorType DoorType { get; set; }
        public int? DoorTypeId { get; set; }
        public FuelType FuelType { get; set; }
        public int? FuelTypeId { get; set; }
        public int? EngineCapacity { get; set; }
        public int? EnginePower { get; set; }
        public DateTime? EndDateDelivery { get; set; }
        public int? AverageFuel { get; set; }
        public int? Volume { get; set; }
        public int? FiscalHP { get; set; }
        public int? Emission { get; set; }
        public string LicensePlate { get; set; }
        public bool IsActive { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
        public Country Country { get; set; }
        public int? CountryId { get; set; }
        public int? BuildYear { get; set; }
        public string Chassis { get; set; }
        public double Kilometers { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ExteriorColor ExteriorColor { get; set; }
        public int? ExteriorColorId { get; set; }
        public InteriorColor InteriorColor { get; set; }
        public int? InteriorColorId { get; set; }
    }
}