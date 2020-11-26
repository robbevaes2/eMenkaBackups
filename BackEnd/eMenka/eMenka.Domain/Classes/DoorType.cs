using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class DoorType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}