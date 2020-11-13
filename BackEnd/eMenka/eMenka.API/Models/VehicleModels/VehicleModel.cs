using System;

namespace eMenka.API.Models.VehicleModels
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int FuelTypeId { get; set; }
        public int MotorTypeId { get; set; }
        public int DoorTypeId { get; set; }
        public int FuelCard { get; set; } //todo refactor to FuelCardModel
        public int Volume { get; set; }
        public int FiscalePk { get; set; }
        public int Emission { get; set; }
        public int Power { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
