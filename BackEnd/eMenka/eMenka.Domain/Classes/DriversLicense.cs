namespace eMenka.Domain.Classes
{
    public class DriversLicense
    {
        public int Id { get; set; }
        public Driver Driver { get; set; }
        public int DriverId { get; set; }
        public string LicenseNumber { get; set; }
        public string Type { get; set; }
    }
}
