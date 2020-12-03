using eMenka.Domain.Classes;
using NUnit.Framework;
using System.Collections.Generic;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class BrandTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new Brand();
        }

        private Brand _sut;

        [Test]
        public void BrandVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }

        [Test]
        public void BrandModelsPropertyCorrectlyGetsAndSetsModels()
        {
            var models = new List<Model>();

            _sut.Models = models;

            Assert.That(_sut.Models, Is.EqualTo(models));
        }

        [Test]
        public void BrandSeriesPropertyCorrectlyGetsAndSetsSeries()
        {
            var series = new List<Series>();

            _sut.Series = series;

            Assert.That(_sut.Series, Is.EqualTo(series));
        }

        [Test]
        public void BrandEngineTypesPropertyCorrectlyGetsAndSetsEngineTypes()
        {
            var engineTypes = new List<EngineType>();

            _sut.EngineTypes = engineTypes;

            Assert.That(_sut.EngineTypes, Is.EqualTo(engineTypes));
        }
    }
}