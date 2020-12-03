using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.VehicleMappers
{
    [TestFixture]
    public class CategoryMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new CategoryMapper();
        }

        private CategoryMapper _sut;

        [Test]
        public void MapCategoryEntityReturnNullWhenModelIsNull()
        {
            Category category = null;

            var result = _sut.MapEntityToReturnModel(category);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapCategoryEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var category = new Category
            {
                Id = id,
                Name = name
            };

            var result = _sut.MapEntityToReturnModel(category);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapCategoryModelReturnsCategoryWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var categoryModel = new CategoryModel
            {
                Id = id,
                Name = name
            };

            var result = _sut.MapModelToEntity(categoryModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }
    }
}