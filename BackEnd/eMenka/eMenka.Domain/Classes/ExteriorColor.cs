using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class ExteriorColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}