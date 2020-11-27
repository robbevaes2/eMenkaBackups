using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.VehicleMappers
{
    [TestFixture]
    public class ModelMapperTests
    {
        private ModelMapper _sut;

        [SetUp]
        public void Init()
        {
            _sut = new ModelMapper();
        }

        [Test]
        public void MapModelEntityReturnNullWhenModelIsNull()
        {
            Model model = null;

            var result = _sut.MapEntityToReturnModel(model);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapModelEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var model = new Model
            {
                Brand = null,
                Id = id,
                Name = name
            };

            var result = _sut.MapEntityToReturnModel(model);

            Assert.That(result.Brand, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapModelModelReturnsModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var brandid = 1;

            var modelModel = new ModelModel
            {
                BrandId = brandid,
                Id = id,
                Name = name
            };

            var result = _sut.MapModelToEntity(modelModel);

            Assert.That(result.BrandId, Is.EqualTo(brandid));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }
    }
}
