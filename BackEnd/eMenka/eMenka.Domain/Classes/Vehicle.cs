using System;

namespace eMenka.Domain.Classes
{
    public class Vehicle
    {
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public FuelType FuelType { get; set; }
        public MotorType MotorType { get; set; }
        public DoorType DoorType { get; set; }
        public int Volume { get; set; }
        public int FiscalePk { get; set; }
        public int Emission { get; set; }
        public int Power { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }

    }
}
