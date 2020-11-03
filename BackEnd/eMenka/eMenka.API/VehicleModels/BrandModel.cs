using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.Domain.Classes;

namespace eMenka.API.VehicleModels
{
    public class BrandModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelModel> Models { get; set; }
        public ICollection<SerieModel> Series { get; set; }
        public ICollection<MotorTypeModel> MotorTypes { get; set; }
        public ICollection<ExteriorColorModel> ExteriorColors { get; set; }
        public ICollection<InteriorColorModel> InteriorColors { get; set; }
    }
}
