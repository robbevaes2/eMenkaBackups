using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.VehicleModels
{
    public class BrandModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelModel> Models { get; set; }
        public ICollection<SerieModel> Series { get; set; }
        public ICollection<MotorTypeModel> MotorTypes { get; set; }
    }
}
