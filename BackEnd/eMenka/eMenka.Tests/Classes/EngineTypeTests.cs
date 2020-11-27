using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class EngineTypeTests
    {
        private EngineType _sut;

        [SetUp]
        public void Init()
        {
            _sut = new EngineType();
        }

        [Test]
        public void EngineTypeVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }
    }
}
