using System;
using eMenka.Domain.Enums;

namespace eMenka.Domain.Classes
{
    public class Record
    {
        public Vehicle Vehicle { get; set; }
        public Company Company { get; set; }
        public string City { get; set; }
        public Term Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Usage Usage { get; set; }
    }
}
