using eMenka.Domain.Classes;
using NUnit.Framework;
using System.Collections.Generic;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class InteriorColorTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new InteriorColor();
        }

        private InteriorColor _sut;

        [Test]
        public void InteriorColorBrandIdPropertyGetsAndSetsBrandId()
        {
            var brandId = 1;

            _sut.BrandId = brandId;

            Assert.That(_sut.BrandId, Is.EqualTo(brandId));
        }

        [Test]
        public void InteriorColorBrandPropertyGetsAndSetsBrand()
        {
            var brand = new Brand();

            _sut.Brand = brand;

            Assert.That(_sut.Brand, Is.EqualTo(brand));
        }

        [Test]
        public void InteriorColorVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }
    }
}