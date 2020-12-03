using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.VehicleMappers
{
    [TestFixture]
    public class DoorTypeMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new DoorTypeMapper();
        }

        private DoorTypeMapper _sut;

        [Test]
        public void MapDoorTypeEntityReturnNullWhenModelIsNull()
        {
            DoorType doorType = null;

            var result = _sut.MapEntityToReturnModel(doorType);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapDoorTypeEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var doorType = new DoorType
            {
                Id = id,
                Name = name
            };

            var result = _sut.MapEntityToReturnModel(doorType);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapDoorTypeModelReturnsDoorTypeWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var doorTypeModel = new DoorTypeModel
            {
                Id = id,
                Name = name
            };

            var result = _sut.MapModelToEntity(doorTypeModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }
    }
}