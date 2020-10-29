using System;

namespace eMenka.Domain.Classes
{
    public class Vehicle
    {
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public Uitvoering Uitvoering { get; set; }
        public EngineType EngineType { get; set; }
        public DoorType DoorType { get; set; }
        public int Volume { get; set; }
        public int Power { get; set; }
        public int FiscalePK { get; set; }
        public int Emission { get; set; }
        public DateTime EndDate { get; set; }

    }
}
