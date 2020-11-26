using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}