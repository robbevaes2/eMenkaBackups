using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;
using System.Collections.Generic;

namespace eMenka.Tests.Mappers.VehicleMappers
{
    [TestFixture]
    public class BrandMapperTests
    {
        private BrandMapper _sut;

        [SetUp]
        public void Init()
        {
            _sut = new BrandMapper();
        }

        [Test]
        public void MapbrandEntityReturnNullWhenModelIsNull()
        {
            Brand brand = null;

            var result = _sut.MapEntityToReturnModel(brand);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapBrandEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var exteriorColors = new List<ExteriorColor>();
            var interiorColors = new List<InteriorColor>();

            var brand = new Brand
            {
                Id = id,
                Name = name,
                ExteriorColors = exteriorColors,
                InteriorColors = interiorColors
            };

            var result = _sut.MapEntityToReturnModel(brand);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.InteriorColors, Is.Not.Null);
            Assert.That(result.ExteriorColors, Is.Not.Null);
        }

        [Test]
        public void MapBrandModelReturnsBrandWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var brandModel = new BrandModel
            {
                Id = id,
                Name = name
            };

            var result = _sut.MapModelToEntity(brandModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }
    }
}
