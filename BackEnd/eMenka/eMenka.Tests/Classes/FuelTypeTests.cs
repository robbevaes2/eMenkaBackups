using System.Collections.Generic;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class FuelTypeTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new FuelType();
        }

        private FuelType _sut;

        [Test]
        public void FuelTypeVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }
    }
}