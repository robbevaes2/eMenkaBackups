using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using eMenka.Domain.Classes;

namespace eMenka.API.VehicleModels
{
    public class VehicleReturnModel
    {
        public BrandReturnModel Brand { get; set; }
        public ModelReturnModel Model { get; set; }
        public FuelType FuelType { get; set; }
        public MotorTypeReturnModel MotorType { get; set; }
        public DoorTypeReturnModel DoorType { get; set; }
        public int Volume { get; set; }
        public int FiscalePk { get; set; }
        public int Emission { get; set; }
        public int Power { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
