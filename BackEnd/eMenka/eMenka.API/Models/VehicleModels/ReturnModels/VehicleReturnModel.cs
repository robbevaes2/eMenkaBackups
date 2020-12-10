using eMenka.API.Models.FuelCardModels.ReturnModels;
using System;
using eMenka.Domain.Classes;

namespace eMenka.API.Models.VehicleModels.ReturnModels
{
    public class VehicleReturnModel
    {
        public int Id { get; set; }
        public BrandReturnModel Brand { get; set; }
        public ModelReturnModel Model { get; set; }
        public FuelTypeReturnModel FuelType { get; set; }
        public EngineTypeReturnModel EngineType { get; set; }
        public DoorTypeReturnModel DoorType { get; set; }
        public CategoryReturnModel Category { get; set; }
        public FuelCardReturnModel FuelCard { get; set; }
        public SerieReturnModel Series { get; set; }
        public int? Volume { get; set; }
        public int? FiscalHP { get; set; }
        public int? Emission { get; set; }
        public bool IsActive { get; set; }
        public string LicensePlate { get; set; }
        public string Chassis { get; set; }
        public int? EngineCapacity { get; set; }
        public int? EnginePower { get; set; }
        public DateTime? EndDateDelivery { get; set; }
        public int? AverageFuel { get; set; }
        public int? BuildYear { get; set; }
        public CountryReturnModel Country { get; set; }
        public double Kilometers { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ExteriorColorReturnModel ExteriorColor { get; set; }
        public InteriorColorReturnModel InteriorColor { get; set; }
    }
}