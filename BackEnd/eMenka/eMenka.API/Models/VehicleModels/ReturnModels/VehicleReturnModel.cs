using System;
using System.Reflection.Metadata;
using eMenka.API.Models.FuelCardModels.ReturnModels;

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
        public int Volume { get; set; }
        public int FiscalePk { get; set; }
        public int Emission { get; set; }
        public int Power { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public string LicensePlate { get; set; }
    }
}
