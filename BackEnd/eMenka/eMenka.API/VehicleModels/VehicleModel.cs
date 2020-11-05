using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;

namespace eMenka.API.VehicleModels
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public BrandModel Brand { get; set; }
        public ModelModel Model { get; set; }
        public int FuelType { get; set; } //todo refactor to FuelTypeModel
        public MotorTypeModel MotorType { get; set; }
        public DoorTypeModel DoorType { get; set; }
        public int FuelCard { get; set; } //todo refactor to FuelCardModel
        public int Volume { get; set; }
        public int FiscalePk { get; set; }
        public int Emission { get; set; }
        public int Power { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
