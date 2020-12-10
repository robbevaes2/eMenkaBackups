using eMenka.API.Controllers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class DoorTypeControllerTests
    {
        private DoorTypeController _sut;
        private Mock<IDoorTypeRepository> _doorTypeRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _doorTypeRepositoryMock = new Mock<IDoorTypeRepository>();
            _mapperMock = new Mock<IMapper>();
            _sut = new DoorTypeController(_doorTypeRepositoryMock.Object, _mapperMock.Object);
        }


        [Test]
        public void GetAllDoorTypesReturnsOkAndListOfAllDoortypesWhenEverythingIsCorrect()
        {
            var doorTypes = new List<DoorType>();

            _doorTypeRepositoryMock.Setup(m => m.GetAll())
                .Returns(doorTypes);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<DoorTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetDoorTypeByIdReturnsNotFoundWhenDoorTypeDoesNotExist()
        {
            DoorType doorType = null;

            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetDoorTypeByIdReturnsOkAndDoorTypeWhenEverythingIsCorrect()
        {
            var doorType = new DoorType();

            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);
            _mapperMock.Setup(m => m.Map<DoorTypeReturnModel>(It.IsAny<DoorType>()))
                .Returns(new DoorTypeReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as DoorTypeReturnModel;
            Assert.That(value, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetDoorTypesByNameReturnsOkAndDoorTypeWhenEverythingIsCorrect()
        {
            var doorTypes = new List<DoorType>();

            _doorTypeRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<DoorType, bool>>>()))
                .Returns(doorTypes);
            _mapperMock.Setup(m => m.Map<DoorTypeReturnModel>(It.IsAny<DoorType>()))
                .Returns(new DoorTypeReturnModel());
            var result = _sut.GetDoorTypeByName("name") as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<DoorTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<DoorType, bool>>>()), Times.Once);
        }

        [Test]
        public void PostDoorTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new DoorTypeModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _doorTypeRepositoryMock.Verify(m => m.Add(It.IsAny<DoorType>()), Times.Never);
        }

        [Test]
        public void PostDoorTypeReturnsOkWhenModelIsValid()
        {
            var validModel = new DoorTypeModel
            {
                Name = "name"
            };
            _mapperMock.Setup(m => m.Map<DoorTypeReturnModel>(It.IsAny<DoorType>()))
                .Returns(new DoorTypeReturnModel());
            _mapperMock.Setup(m => m.Map<DoorType>(It.IsAny<DoorTypeModel>()))
                .Returns(new DoorType());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((DoorTypeReturnModel)result.Value, Is.Not.Null);

            _doorTypeRepositoryMock.Verify(m => m.Add(It.IsAny<DoorType>()), Times.Once);
        }

        [Test]
        public void UpdateDoorTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new DoorTypeModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _doorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<DoorType>()), Times.Never);
        }

        [Test]
        public void UpdateDoorTypeReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new DoorTypeModel
            {
                Id = 1
            };

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _doorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<DoorType>()), Times.Never);
        }

        [Test]
        public void UpdateDoorTypeReturnsNotFoundWhenDoorTypeIsNotFound()
        {
            var invalidModel = new DoorTypeModel
            {
                Id = 1
            };

            _doorTypeRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<DoorType>()))
                .Returns(false);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _doorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<DoorType>()), Times.Once);
        }

        [Test]
        public void UpdateDoorTypeReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new DoorTypeModel
            {
                Id = 1,
                Name = ""
            };

            _doorTypeRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<DoorType>()))
                .Returns(true);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _doorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<DoorType>()), Times.Once);
        }

        [Test]
        public void DeleteDoorTypeReturnsNotFoundWhenDoorTypeIsNotFound()
        {
            DoorType doorType = null;

            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<DoorType>()), Times.Never);
        }

        [Test]
        public void DeleteDoorTypeReturnsOkWhenEverythingIsCorrect()
        {
            var doorType = new DoorType();

            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<DoorType>()), Times.Once);
        }
    }
}