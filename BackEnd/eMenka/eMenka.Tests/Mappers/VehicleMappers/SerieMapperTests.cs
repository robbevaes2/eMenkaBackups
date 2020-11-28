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
    public class SerieMapperTests
    {
        private SerieMapper _sut;

        [SetUp]
        public void Init()
        {
            _sut = new SerieMapper();
        }

        [Test]
        public void MapSerieEntityReturnNullWhenSerieIsNull()
        {
            Series series = null;

            var result = _sut.MapEntityToReturnModel(series);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapSerieEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var series = new Series
            {
                Brand = null,
                Id = id,
                Name = name
            };

            var result = _sut.MapEntityToReturnModel(series);

            Assert.That(result.Brand, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapSerieModelReturnsSeriesWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var brandid = 1;

            var serieModel = new SerieModel
            {
                BrandId = brandid,
                Id = id,
                Name = name
            };

            var result = _sut.MapModelToEntity(serieModel);

            Assert.That(result.BrandId, Is.EqualTo(brandid));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }
    }
}
