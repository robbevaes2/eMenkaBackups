using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.VehicleMappers
{
    [TestFixture]
    public class CountryMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new CountryMapper();
        }

        private CountryMapper _sut;

        [Test]
        public void MapCountryEntityReturnNullWhenModelIsNull()
        {
            Country country = null;

            var result = _sut.MapEntityToReturnModel(country);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapCountryEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var code = "code";
            var isActive = true;
            var nationality = "nation";
            var pod = true;

            var country = new Country
            {
                Id = id,
                Name = name,
                IsActive = isActive,
                Code = code,
                Nationality = nationality,
                POD = pod
            };

            var result = _sut.MapEntityToReturnModel(country);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.Nationality, Is.EqualTo(nationality));
            Assert.That(result.POD, Is.EqualTo(pod));
        }

        [Test]
        public void MapCountryModelReturnsCategoryWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var code = "code";
            var isActive = true;
            var nationality = "nation";
            var pod = true;

            var countryModel = new CountryModel
            {
                Id = id,
                Name = name,
                IsActive = isActive,
                Code = code,
                Nationality = nationality,
                POD = pod
            };

            var result = _sut.MapModelToEntity(countryModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.Nationality, Is.EqualTo(nationality));
            Assert.That(result.POD, Is.EqualTo(pod));
        }
    }
}