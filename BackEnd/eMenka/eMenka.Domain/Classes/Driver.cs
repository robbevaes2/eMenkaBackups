using eMenka.Domain.Enums;

namespace eMenka.Domain.Classes
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DriversLicense DriversLicense { get; set; }
        public Language Language { get; set; }
    }
}
