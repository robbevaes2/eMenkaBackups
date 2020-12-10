using AutoMapper;
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
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _countryRepositoryMock = new Mock<ICountryRepository>();
            _mapperMock = new Mock<IMapper>();
            
        }

        [Test]
        public void ConstructorSetsCorrectPropertiesInBaseClass()
        {
            GenericController<Country, CountryModel, CountryReturnModel> countryController =
                new CountryController(_countryRepositoryMock.Object, _mapperMock.Object);

            _countryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(new Country());
            _mapperMock.Setup(m => m.Map<CountryReturnModel>(It.IsAny<Country>()))
                .Returns(new CountryReturnModel());

            var result = countryController.GetEntityById(1) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((CountryReturnModel)result.Value, Is.Not.Null);
        }
    }
}