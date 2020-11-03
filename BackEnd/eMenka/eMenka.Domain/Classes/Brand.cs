using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        public ICollection<Serie> Series { get; set; }
        public ICollection<MotorType> MotorTypes { get; set; }
        public ICollection<ExteriorColor> ExteriorColors { get; set; }
        public ICollection<InteriorColor> InteriorColors { get; set; }
    }
}
