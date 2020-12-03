using eMenka.Domain.Classes;
using NUnit.Framework;
using System.Collections.Generic;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class EngineTypeTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new EngineType();
        }

        private EngineType _sut;

        [Test]
        public void EngineTypeVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }
    }
}