using eMenka.Domain.Classes;
using NUnit.Framework;
using System.Collections.Generic;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class ExteriorColorTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new ExteriorColor();
        }

        private ExteriorColor _sut;

        [Test]
        public void ExteriorColorBrandIdPropertyGetsAndSetsBrandId()
        {
            var brandId = 1;

            _sut.BrandId = brandId;

            Assert.That(_sut.BrandId, Is.EqualTo(brandId));
        }

        [Test]
        public void ExteriorColorBrandPropertyGetsAndSetsBrand()
        {
            var brand = new Brand();

            _sut.Brand = brand;

            Assert.That(_sut.Brand, Is.EqualTo(brand));
        }

        [Test]
        public void ExteriorColorVehiclesPropertyCorrectlyGetsAndSetsVehicles()
        {
            var vehicles = new List<Vehicle>();

            _sut.Vehicles = vehicles;

            Assert.That(_sut.Vehicles, Is.EqualTo(vehicles));
        }
    }
}