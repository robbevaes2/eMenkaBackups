using System;

namespace eMenka.Domain.Classes
{
    public class FuelCard
    {
        public int Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
        public Driver Driver { get; set; }
        public int DriverId { get; set; }
        public Record Record { get; set; }
        public int RecordId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Active { get; set; }
    }
}