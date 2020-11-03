using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.Domain.Enums;

namespace eMenka.API.VehicleModels
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public FuelType FuelType { get; set; }
        public int MotorTypeId { get; set; }
        public DoorType DoorType { get; set; }
        public int FuelCardId { get; set; }
        public int Volume { get; set; }
        public int FiscalePk { get; set; }
        public int Emission { get; set; }
        public int Power { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
