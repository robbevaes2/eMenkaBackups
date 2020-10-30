using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class Brand
    {
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        public ICollection<Serie> Series { get; set; }
        public ICollection<MotorType> MotorTypes { get; set; }
    }
}
