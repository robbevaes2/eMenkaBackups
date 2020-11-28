using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class ModelTests
    {
        private Model _sut;

        [SetUp]
        public void Init()
        {
            _sut = new Model();
        }

        [Test]
        public void ModelVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }
    }
}
