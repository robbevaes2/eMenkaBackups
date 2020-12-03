using eMenka.Domain.Classes;
using NUnit.Framework;
using System.Collections.Generic;

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