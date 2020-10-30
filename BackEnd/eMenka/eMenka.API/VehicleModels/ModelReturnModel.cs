using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using eMenka.Domain.Classes;

namespace eMenka.API.VehicleModels
{
    public class ModelReturnModel
    {
        public string Name { get; set; }
        public BrandReturnModel Brand { get; set; }
    }
}
