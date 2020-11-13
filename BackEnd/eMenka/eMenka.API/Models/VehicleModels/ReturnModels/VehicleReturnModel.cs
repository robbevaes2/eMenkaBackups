using System;

namespace eMenka.API.Models.VehicleModels.ReturnModels
{
    public class VehicleReturnModel
    {
        public int Id { get; set; }
        public BrandReturnModel Brand { get; set; }
        public ModelReturnModel Model { get; set; }
        public FuelTypeReturnModel FuelType { get; set; } 
        public MotorTypeReturnModel MotorType { get; set; }
        public DoorTypeReturnModel DoorType { get; set; }
        public int FuelCard { get; set; } //todo refactor to FuelCardModel
        public int Volume { get; set; }
        public int FiscalePk { get; set; }
        public int Emission { get; set; }
        public int Power { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
