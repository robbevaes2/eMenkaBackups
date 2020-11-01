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
        public ICollection<ExteriorColor> ExteriorColors { get; set; }
        public ICollection<InteriorColor> InteriorColors { get; set; }
    }
}
