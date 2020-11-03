using System.Collections.Generic;
using eMenka.Domain.Classes;

namespace eMenka.Domain.Enums
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
