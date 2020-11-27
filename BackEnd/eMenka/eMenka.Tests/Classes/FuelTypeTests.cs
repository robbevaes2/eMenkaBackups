using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class FuelTypeTests
    {
        private FuelType _sut;

        [SetUp]
        public void Init()
        {
            _sut = new FuelType();
        }

        [Test]
        public void FuelTypeVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }
    }
}
