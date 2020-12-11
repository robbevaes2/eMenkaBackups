using eMenka.API.Controllers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using AutoMapper;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class FuelTypeControllerTests
    {
        private FuelTypeController _sut;
        private Mock<IFuelTypeRepository> _fuelTypeRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _fuelTypeRepositoryMock = new Mock<IFuelTypeRepository>();
            _mapperMock = new Mock<IMapper>();
            _sut = new FuelTypeController(_fuelTypeRepositoryMock.Object, _mapperMock.Object);
        }


        [Test]
        public void GetAllFuelTypesReturnsOkAndListOfAllFueltypesWhenEverythingIsCorrect()
        {
            var fuelTypes = new List<FuelType>();

            _fuelTypeRepositoryMock.Setup(m => m.GetAll())
                .Returns(fuelTypes);

            var result = _sut.GetAllEntities() as OkObjectResult;

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

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetFuelTypeByIdReturnsOkAndFuelTypeWhenEverythingIsCorrect()
        {
            var fuelType = new FuelType();

            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _mapperMock.Setup(m => m.Map<FuelTypeReturnModel>(It.IsAny<FuelType>()))
                .Returns(new FuelTypeReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

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

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

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
            _mapperMock.Setup(m => m.Map<FuelTypeReturnModel>(It.IsAny<FuelType>()))
                .Returns(new FuelTypeReturnModel());
            _mapperMock.Setup(m => m.Map<FuelType>(It.IsAny<FuelTypeModel>()))
                .Returns(new FuelType());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((FuelTypeReturnModel)result.Value, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.Add(It.IsAny<FuelType>()), Times.Once);
        }

        [Test]
        public void UpdateFuelTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new FuelTypeModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

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

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

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

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

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

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelType>()), Times.Once);
        }

        [Test]
        public void DeleteFuelTypeReturnsNotFoundWhenFuelTypeIsNotFound()
        {
            FuelType fuelType = null;

            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

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

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<FuelType>()), Times.Once);
        }
    }
}