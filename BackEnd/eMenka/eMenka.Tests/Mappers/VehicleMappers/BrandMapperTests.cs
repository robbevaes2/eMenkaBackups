using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

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
            var code = "code";
            var exteriorColors = new List<ExteriorColor>
            {
                new ExteriorColor
                {
                    Id = id,
                    Code = code,
                    Name = name
                },
                null
            };
            var interiorColors= new List<InteriorColor>
            {
                new InteriorColor
                {
                    Id = id,
                    Code = code,
                    Name = name
                }, 
                null
            };

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
            Assert.That(result.InteriorColors[1], Is.Null);
            Assert.That(result.ExteriorColors[1], Is.Null);

            Assert.That(result.InteriorColors[0].Id, Is.EqualTo(id));
            Assert.That(result.InteriorColors[0].Name, Is.EqualTo(name));
            Assert.That(result.InteriorColors[0].Code, Is.EqualTo(code));

            Assert.That(result.ExteriorColors[0].Id, Is.EqualTo(id));
            Assert.That(result.ExteriorColors[0].Name, Is.EqualTo(name));
            Assert.That(result.ExteriorColors[0].Code, Is.EqualTo(code));
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
