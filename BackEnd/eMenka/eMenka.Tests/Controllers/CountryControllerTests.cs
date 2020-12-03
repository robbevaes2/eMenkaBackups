using eMenka.API.Controllers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace eMenka.Tests.Controllers
{
    public class CountryControllerTests
    {
        private Mock<ICountryRepository> _countryRepositoryMock;

        [SetUp]
        public void Init()
        {
            _countryRepositoryMock = new Mock<ICountryRepository>();
        }

        [Test]
        public void ConstructorSetsCorrectPropertiesInBaseClass()
        {
            GenericController<Country, CountryModel, CountryReturnModel> countryController =
                new CountryController(_countryRepositoryMock.Object);

            _countryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(new Country());

            var result = countryController.GetEntityById(1) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((CountryReturnModel) result.Value, Is.Not.Null);
        }
    }
}