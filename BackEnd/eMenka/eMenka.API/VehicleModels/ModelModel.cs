using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.VehicleModels
{
    public class ModelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandModel Brand { get; set; }
    }
}
