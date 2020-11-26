using eMenka.API.Controllers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class FuelTypeControllerTests
    {
        [SetUp]
        public void Init()
        {
            _fuelTypeRepositoryMock = new Mock<IFuelTypeRepository>();
            _sut = new FuelTypeController(_fuelTypeRepositoryMock.Object);
        }

        private FuelTypeController _sut;
        private Mock<IFuelTypeRepository> _fuelTypeRepositoryMock;

        [Test]
        public void GetAllFuelTypesReturnsOkAndListOfAllFueltypesWhenEverythingIsCorrect()
        {
            var fuelTypes = new List<FuelType>();

            _fuelTypeRepositoryMock.Setup(m => m.GetAll())
                .Returns(fuelTypes);

            var result = _sut.GetAllFuelTypes() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<FuelTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _fuelTypeRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetFuelTypeByIdReturnsNotFoundWhenFuelTypeDoesNotExist()
        {
            FuelType fuelType = null;

            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);

            var result = _sut.GetFuelTypeById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetFuelTypeByIdReturnsOkAndFuelTypeWhenEverythingIsCorrect()
        {
            var fuelType = new FuelType();

            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);

            var result = _sut.GetFuelTypeById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as FuelTypeReturnModel;
            Assert.That(value, Is.Not.Null);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostFuelTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new FuelTypeModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostFuelType(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.Add(It.IsAny<FuelType>()), Times.Never);
        }

        [Test]
        public void PostFuelTypeReturnsOkWhenModelIsValid()
        {
            var validModel = new FuelTypeModel
            {
                Name = "name"
            };

            var result = _sut.PostFuelType(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.Add(It.IsAny<FuelType>()), Times.Once);
        }

        [Test]
        public void UpdateFuelTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new FuelTypeModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateFuelType(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelType>()), Times.Never);
        }

        [Test]
        public void UpdateFuelTypeReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new FuelTypeModel
            {
                Id = 1
            };

            var result = _sut.UpdateFuelType(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelType>()), Times.Never);
        }

        [Test]
        public void UpdateFuelTypeReturnsNotFoundWhenFuelTypeIsNotFound()
        {
            var invalidModel = new FuelTypeModel
            {
                Id = 1
            };

            _fuelTypeRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<FuelType>()))
                .Returns(false);

            var result = _sut.UpdateFuelType(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelType>()), Times.Once);
        }

        [Test]
        public void UpdateFuelTypeReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new FuelTypeModel
            {
                Id = 1,
                Name = ""
            };

            _fuelTypeRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<FuelType>()))
                .Returns(true);

            var result = _sut.UpdateFuelType(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelType>()), Times.Once);
        }

        [Test]
        public void DeleteFuelTypeReturnsNotFoundWhenFuelTypeIsNotFound()
        {
            FuelType fuelType = null;

            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);

            var result = _sut.DeleteFuelType(1) as NotFoundResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<FuelType>()), Times.Never);
        }

        [Test]
        public void DeleteFuelTypeReturnsOkWhenEverythingIsCorrect()
        {
            var fuelType = new FuelType();

            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);

            var result = _sut.DeleteFuelType(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<FuelType>()), Times.Once);
        }
    }
}