using System;

namespace eMenka.Domain.Classes
{
    public class Driver
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public FuelCard FuelCard { get; set; }
        public int? FuelCardId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}