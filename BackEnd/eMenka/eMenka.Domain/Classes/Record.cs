using eMenka.Domain.Enums;
using System;

namespace eMenka.Domain.Classes
{
    public class Record
    {
        public int Id { get; set; }
        public FuelCard FuelCard { get; set; }
        public int FuelCardId { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string City { get; set; }
        public Term Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Usage Usage { get; set; }
    }
}
