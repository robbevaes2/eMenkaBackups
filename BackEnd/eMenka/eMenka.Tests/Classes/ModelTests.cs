using System.Collections.Generic;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class ModelTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new Model();
        }

        private Model _sut;

        [Test]
        public void ModelVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }
    }
}