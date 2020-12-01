using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.VehicleMappers
{
    [TestFixture]
    public class EngineTypeMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new EngineTypeMapper();
        }

        private EngineTypeMapper _sut;

        [Test]
        public void MapEngineTypeEntityReturnNullWhenEngineTypeIsNull()
        {
            EngineType engineType = null;

            var result = _sut.MapEntityToReturnModel(engineType);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapEngineTypeEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var engineType = new EngineType
            {
                Brand = null,
                Id = id,
                Name = name
            };

            var result = _sut.MapEntityToReturnModel(engineType);

            Assert.That(result.Brand, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapEngineTypeModelReturnsEngineTypeWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var brandid = 1;

            var engineTypeModel = new EngineTypeModel
            {
                BrandId = brandid,
                Id = id,
                Name = name
            };

            var result = _sut.MapModelToEntity(engineTypeModel);

            Assert.That(result.BrandId, Is.EqualTo(brandid));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }
    }
}