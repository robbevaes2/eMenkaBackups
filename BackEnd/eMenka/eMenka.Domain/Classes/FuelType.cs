using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}