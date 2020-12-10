using System;

namespace eMenka.Domain.Classes
{
    public class Refill
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public FuelCard FuelCard { get; set; }
        public int FuelCardId { get; set; }
        public double Liters { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Kilometers { get; set; }
        public double TotalPrice { get; set; }
    }
}
