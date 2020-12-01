using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Model> Models { get; set; }
        public ICollection<Series> Series { get; set; }
        public ICollection<EngineType> EngineTypes { get; set; }
        public ICollection<ExteriorColor> ExteriorColors { get; set; } = new List<ExteriorColor>();
        public ICollection<InteriorColor> InteriorColors { get; set; } = new List<InteriorColor>();
    }
}