using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class EngineType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}