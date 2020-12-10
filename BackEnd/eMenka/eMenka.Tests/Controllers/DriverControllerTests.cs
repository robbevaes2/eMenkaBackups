using System;
using eMenka.API.Controllers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class DriverControllerTests
    {
        private DriverController _sut;
        private Mock<IDriverRepository> _driverRepositoryMock;
        private Mock<IPersonRepository> _personRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _driverRepositoryMock = new Mock<IDriverRepository>();
            _personRepositoryMock = new Mock<IPersonRepository>();
            _mapperMock = new Mock<IMapper>();
            _sut = new DriverController(_driverRepositoryMock.Object, _personRepositoryMock.Object, _mapperMock.Object);
        }

        [Test]
        public void GetAllDriversReturnsOkAndListOfAllDriversWhenEverythingIsCorrect()
        {
            var drivers = new List<Driver>();

            _driverRepositoryMock.Setup(m => m.GetAll())
                .Returns(drivers);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<DriverReturnModel>;
            Assert.That(value, Is.Not.Null);
            _driverRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetAllAvailableDriversReturnsOkAndListOfAllAvailableDriversWhenEverythingIsCorrect()
        {
            var drivers = new List<Driver>();

            _driverRepositoryMock.Setup(m => m.GetAllAvailableDrivers())
                .Returns(drivers);
            _mapperMock.Setup(m => m.Map<DriverReturnModel>(It.IsAny<Driver>()))
                .Returns(new DriverReturnModel());
            var result = _sut.GetAllAvailableDrivers() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as IEnumerable<DriverReturnModel>;
            Assert.That(value, Is.Not.Null);
            _driverRepositoryMock.Verify(m => m.GetAllAvailableDrivers(), Times.Once);
        }

        [Test]
        public void GetDriverByIdReturnsNotFoundWhenDriverDoesNotExist()
        {
            Driver driver = null;

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetDriverByIdReturnsOkAndDriverWhenEverythingIsCorrect()
        {
            var driver = new Driver();

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _mapperMock.Setup(m => m.Map<DriverReturnModel>(It.IsAny<Driver>()))
                .Returns(new DriverReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as DriverReturnModel;
            Assert.That(value, Is.Not.Null);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetDriversByEndDateReturnsOkAndDriversWhenEverythingIsCorrect()
        {
            var drivers = new List<Driver>();

            _driverRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Driver, bool>>>()))
                .Returns(drivers);
            _mapperMock.Setup(m => m.Map<DriverReturnModel>(It.IsAny<Driver>()))
                .Returns(new DriverReturnModel());
            var result = _sut.GetDriverByEndDate(10) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<DriverReturnModel>;
            Assert.That(value, Is.Not.Null);
            _driverRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Driver, bool>>>()), Times.Once);
        }

        [Test]
        public void PostDriverReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new DriverModel
            {
                PersonId = 1
            };

            var person = new Person();

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Add(It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostDriverReturnsNotFoundWhenPersonIsNotFound()
        {
            var validModel = new DriverModel
            {
                PersonId = 1
            };

            Person person = null;

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Add(It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostDriverReturnsOkWhenModelIsValid()
        {
            var validModel = new DriverModel
            {
                PersonId = 1
            };

            var person = new Person();

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);
            _mapperMock.Setup(m => m.Map<DriverReturnModel>(It.IsAny<Driver>()))
                .Returns(new DriverReturnModel());
            _mapperMock.Setup(m => m.Map<Driver>(It.IsAny<DriverModel>()))
                .Returns(new Driver());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((DriverReturnModel)result.Value, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Add(It.IsAny<Driver>()), Times.Once);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateDriverReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new DriverModel
            {
                PersonId = 1
            };

            var person = new Person();

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateDriverReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new DriverModel
            {
                Id = 1,
                PersonId = 1
            };

            var person = new Person();

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateDriverReturnsNotFoundWhenPersonIsNotFound()
        {
            var validModel = new DriverModel
            {
                Id = 1,
                PersonId = 1
            };

            Person person = null;

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateDriverReturnsNotFoundWhenDriverIsNotFound()
        {
            var invalidModel = new DriverModel
            {
                Id = 1,
                PersonId = 1
            };

            var person = new Person();

            _driverRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()))
                .Returns(false);
            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Once);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateDriverReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new DriverModel
            {
                Id = 1,
                PersonId = 1
            };

            var person = new Person();

            _driverRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()))
                .Returns(true);
            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Once);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteDriverReturnsNotFoundWhenDriverIsNotFound()
        {
            Driver driver = null;

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.Remove(It.IsAny<Driver>()), Times.Never);
        }

        [Test]
        public void DeleteDriverReturnsOkWhenEverythingIsCorrect()
        {
            var driver = new Driver();

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.Remove(It.IsAny<Driver>()), Times.Once);
        }
    }
}