using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.VehicleMappers
{
    [TestFixture]
    public class FuelTypeTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new FuelTypeMapper();
        }

        private FuelTypeMapper _sut;

        [Test]
        public void MapFuelTypeEntityReturnNullWhenModelIsNull()
        {
            FuelType fuelType = null;

            var result = _sut.MapEntityToReturnModel(fuelType);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapFuelTypeEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var code = "code";

            var fuelType = new FuelType
            {
                Id = id,
                Name = name,
                Code = code
            };

            var result = _sut.MapEntityToReturnModel(fuelType);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
        }

        [Test]
        public void MapFuelTypeModelReturnsBrandWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var code = "code";

            var fuelTypeModel = new FuelTypeModel
            {
                Id = id,
                Name = name,
                Code = code
            };

            var result = _sut.MapModelToEntity(fuelTypeModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
        }
    }
}