using eMenka.Domain.Enums;

namespace eMenka.Domain.Classes
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public FuelCard FuelCard { get; set; }
        public int FuelCardId { get; set; }
        public Language Language { get; set; }
    }
}
