using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.VehicleModels
{
    public class MotorTypeReturnModel
    {
        public string Name { get; set; }
        public BrandReturnModel Brand { get; set; }
    }
}
