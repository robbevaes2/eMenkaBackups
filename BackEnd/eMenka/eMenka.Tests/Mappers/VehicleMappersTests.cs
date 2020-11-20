using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers
{
    [TestFixture]
    public class VehicleMappersTests
    {
        [Test]
        public void MapVehicleEntityReturnNullWhenVehicleIsNull()
        {
            Vehicle vehicle = null;

            var result = VehicleMappers.MapVehicleEntity(vehicle);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapVehicleEntityReturnsReturnModelWithCorrectProperties()
        {
            //todo add country and buildyear
            int id = 1;
            int emission = 1;
            int fiscalhp = 1;
            bool isActive = true;
            int power = 1;
            int volume = 1;
            string licensePlate = "plate";
            string chassis = "chassis";
            int averageFuel = 1;
            DateTime enDateDelivery = DateTime.Now;
            int engineCapacity = 1;
            int enginePower = 1;

            Vehicle vehicle = new Vehicle
            {
                AverageFuel = averageFuel,
                Brand = null,
                Category = null,
                Id = id,
                FuelType = null,
                EngineType = null,
                DoorType = null,
                Emission = emission,
                FiscalHP = fiscalhp,
                IsActive = isActive,
                Power = power,
                Volume = volume,
                Model = null,
                FuelCard = null,
                LicensePlate = licensePlate,
                Chassis = chassis,
                EndDateDelivery = enDateDelivery,
                EngineCapacity = engineCapacity,
                EnginePower = enginePower,
                Series = null
            };
        }
    }
}
