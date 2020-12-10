using System;
using System.Collections.Generic;

namespace eMenka.Domain.Classes
{
    public class FuelCard
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int? VehicleId { get; set; }
        public Driver Driver { get; set; }
        public int? DriverId { get; set; }
        public Record Record { get; set; }
        public int? RecordId { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime? BlockingDate { get; set; }
        public string BlockingReason { get; set; }
        public string PinCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IEnumerable<Refill> Refills { get; set; }

    }
}