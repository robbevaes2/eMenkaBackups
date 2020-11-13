using System;

namespace eMenka.API.VehicleModels.ReturnModels
{
    public class VehicleReturnModel
    {
        public int Id { get; set; }
        public BrandReturnModel BrandReturn { get; set; }
        public ModelReturnModel ModelReturn { get; set; }
        public FuelTypeReturnModel FuelTypeReturn { get; set; } 
        public MotorTypeReturnModel MotorTypeReturn { get; set; }
        public DoorTypeReturnModel DoorTypeReturn { get; set; }
        public int FuelCard { get; set; } //todo refactor to FuelCardModel
        public int Volume { get; set; }
        public int FiscalePk { get; set; }
        public int Emission { get; set; }
        public int Power { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
