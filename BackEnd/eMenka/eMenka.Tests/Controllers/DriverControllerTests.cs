﻿using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Controllers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class DriverControllerTests
    {
        private DriverController _sut;
        private Mock<IDriverRepository> _driverRepositoryMock;
        private Mock<IPersonRepository> _personRepositoryMock;

        [SetUp]
        public void Init()
        {
            _driverRepositoryMock = new Mock<IDriverRepository>();
            _personRepositoryMock = new Mock<IPersonRepository>();
            _sut = new DriverController(_driverRepositoryMock.Object, _personRepositoryMock.Object);
        }

        [Test]
        public void GetAllDriversReturnsOkAndListOfAllDriversWhenEverythingIsCorrect()
        {
            var drivers = new List<Driver>();

            _driverRepositoryMock.Setup(m => m.GetAll())
                .Returns(drivers);

            var result = _sut.GetAllDrivers() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<DriverReturnModel>;
            Assert.That(value, Is.Not.Null);
            _driverRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetDriverByIdReturnsNotFoundWhenDriverDoesNotExist()
        {
            Driver driver = null;

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.GetDriverById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetDriverByIdReturnsOkAndDriverWhenEverythingIsCorrect()
        {
            var driver = new Driver();

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.GetDriverById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as DriverReturnModel;
            Assert.That(value, Is.Not.Null);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostDriverReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new DriverModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostDriver(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Add(It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostDriverReturnsNotFoundWhenPersonIsNotFound()
        {
            var validModel = new DriverModel()
            {
                PersonId = 1
            };

            Person person = null;

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.PostDriver(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Add(It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostDriverReturnsOkWhenModelIsValid()
        {
            var validModel = new DriverModel()
            {
                PersonId = 1
            };

            var person = new Person();

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.PostDriver(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Add(It.IsAny<Driver>()), Times.Once);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateDriverReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new DriverModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateDriver(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateDriverReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new DriverModel()
            {
                Id = 1,
                PersonId = 1
            };

            var result = _sut.UpdateDriver(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateDriverReturnsNotFoundWhenPersonIsNotFound()
        {
            var validModel = new DriverModel()
            {
                Id = 1,
                PersonId = 1
            };

            Person person = null;

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.UpdateDriver(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Never);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateDriverReturnsNotFoundWhenDriverIsNotFound()
        {
            var invalidModel = new DriverModel()
            {
                Id = 1,
                PersonId = 1
            };

            var person = new Person();

            _driverRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()))
                .Returns(false);
            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.UpdateDriver(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()), Times.Once);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateDriverReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new DriverModel()
            {
                Id = 1,
                PersonId = 1
            };

            var person = new Person();

            _driverRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Driver>()))
                .Returns(true);
            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.UpdateDriver(validModel, validModel.Id) as OkResult;

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

            var result = _sut.DeleteDriver(1) as NotFoundResult;

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

            var result = _sut.DeleteDriver(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.Remove(It.IsAny<Driver>()), Times.Once);
        }
    }
}