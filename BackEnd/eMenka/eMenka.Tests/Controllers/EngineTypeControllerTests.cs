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

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class EngineTypeControllerTests
    {
        [SetUp]
        public void Init()
        {
            _engineTypeRepositoryMock = new Mock<IEngineTypeRepository>();
            _brandRepositoryMock = new Mock<IBrandRepository>();
            _sut = new EngineTypeController(_engineTypeRepositoryMock.Object, _brandRepositoryMock.Object);
        }

        private EngineTypeController _sut;
        private Mock<IEngineTypeRepository> _engineTypeRepositoryMock;
        private Mock<IBrandRepository> _brandRepositoryMock;

        [Test]
        public void GetAllEngineTypesReturnsOkAndListOfAllEngineTypesWhenEverythingIsCorrect()
        {
            var engineTypes = new List<EngineType>();

            _engineTypeRepositoryMock.Setup(m => m.GetAll())
                .Returns(engineTypes);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<EngineTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _engineTypeRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetEngineTypeByIdReturnsNotFoundWhenEngineTypeDoesNotExist()
        {
            EngineType engineType = null;

            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);

            var result = _sut.GetEntityById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetEngineTypeByIdReturnsOkAndEngineTypeWhenEverythingIsCorrect()
        {
            var engineType = new EngineType
            {
                Brand = new Brand()
            };

            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);

            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as EngineTypeReturnModel;
            Assert.That(value, Is.Not.Null);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetEngineTypesByBrandIdReturnsNotFoundWhenBrandDoesNotExist()
        {
            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.GetEngineTypesByBrandId(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<EngineType, bool>>>()), Times.Never);
        }

        [Test]
        public void GetEngineTypesByBrandIdReturnsOkAndEngineTypeWhenEverythingIsCorrect()
        {
            var brand = new Brand();
            var engineTypes = new List<EngineType>();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _engineTypeRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<EngineType, bool>>>()))
                .Returns(engineTypes);

            var result = _sut.GetEngineTypesByBrandId(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<EngineTypeReturnModel>;
            Assert.That(value, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<EngineType, bool>>>()), Times.Once);
        }

        [Test]
        public void GetEngineTypesByNameReturnsOkAndEngineTypeWhenEverythingIsCorrect()
        {
            var engineTypes = new List<EngineType>();

            _engineTypeRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<EngineType, bool>>>()))
                .Returns(engineTypes);

            var result = _sut.GetEngineTypeByName("name") as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<EngineTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _engineTypeRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<EngineType, bool>>>()), Times.Once);
        }

        [Test]
        public void PostEngineTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new EngineTypeModel
            {
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.Add(It.IsAny<EngineType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostEngineTypeReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new EngineTypeModel
            {
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.Add(It.IsAny<EngineType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostEngineTypeReturnsOkWhenModelIsValid()
        {
            var validModel = new EngineTypeModel
            {
                Name = "name",
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostEntity(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.Add(It.IsAny<EngineType>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateEngineTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new EngineTypeModel
            {
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<EngineType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateEngineTypeReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new EngineTypeModel
            {
                Id = 1,
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<EngineType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateEngineTypeReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new EngineTypeModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<EngineType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateEngineTypeReturnsNotFoundWhenModelIsNotFound()
        {
            var invalidModel = new EngineTypeModel
            {
                Id = 1,
                BrandId = 1
            };

            var brand = new Brand();

            _engineTypeRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<EngineType>()))
                .Returns(false);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<EngineType>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateEngineTypeReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new EngineTypeModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            var brand = new Brand();

            _engineTypeRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<EngineType>()))
                .Returns(true);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<EngineType>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteEngineTypeReturnsNotFoundWhenEngineTypeIsNotFound()
        {
            EngineType engineType = null;

            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);

            var result = _sut.DeleteEntity(1) as NotFoundResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<EngineType>()), Times.Never);
        }

        [Test]
        public void DeleteEngineTypeReturnsOkWhenEverythingIsCorrect()
        {
            var engineType = new EngineType();

            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<EngineType>()), Times.Once);
        }
    }
}