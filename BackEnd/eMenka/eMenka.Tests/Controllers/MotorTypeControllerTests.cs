using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
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
    [TestFixture]
    public class MotorTypeControllerTests
    {
        private MotorTypeController _sut;
        private Mock<IMotorTypeRepository> _motorTypeRepositoryMock;
        private Mock<IBrandRepository> _brandRepositoryMock;

        [SetUp]
        public void Init()
        {
            _motorTypeRepositoryMock = new Mock<IMotorTypeRepository>();
            _brandRepositoryMock = new Mock<IBrandRepository>();
            _sut = new MotorTypeController(_motorTypeRepositoryMock.Object, _brandRepositoryMock.Object);
        }

        [Test]
        public void GetAllMotorTypesReturnsOkAndListOfAllMotorTypesWhenEverythingIsCorrect()
        {
            var motorTypes = new List<MotorType>();

            _motorTypeRepositoryMock.Setup(m => m.GetAll())
                .Returns(motorTypes);

            var result = _sut.GetAllMotorTypes() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<MotorTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _motorTypeRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetMotorTypeByIdReturnsNotFoundWhenMotorTypeDoesNotExist()
        {
            MotorType motorType = null;

            _motorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(motorType);

            var result = _sut.GetMotorTypeById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _motorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetMotorTypeByIdReturnsOkAndMotorTypeWhenEverythingIsCorrect()
        {
            var motorType = new MotorType
            {
                Brand = new Brand()
            };

            _motorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(motorType);

            var result = _sut.GetMotorTypeById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as MotorTypeReturnModel;
            Assert.That(value, Is.Not.Null);
            _motorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetMotorTypesByBrandIdReturnsNotFoundWhenBrandDoesNotExist()
        {
            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.GetMotorTypesByBrandId(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _motorTypeRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<MotorType, bool>>>()), Times.Never);
        }

        [Test]
        public void GetMotorTypesByBrandIdReturnsOkAndMotorTypeWhenEverythingIsCorrect()
        {
            var brand = new Brand();
            var motorTypes = new List<MotorType>();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _motorTypeRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<MotorType, bool>>>()))
                .Returns(motorTypes);

            var result = _sut.GetMotorTypesByBrandId(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<MotorTypeReturnModel>;
            Assert.That(value, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _motorTypeRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<MotorType, bool>>>()), Times.Once);
        }

        [Test]
        public void GetMotorTypesByNameReturnsOkAndMotorTypeWhenEverythingIsCorrect()
        {
            var motorTypes = new List<MotorType>();

            _motorTypeRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<MotorType, bool>>>()))
                .Returns(motorTypes);

            var result = _sut.GetMotorTypesByName("name") as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<MotorTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _motorTypeRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<MotorType, bool>>>()), Times.Once);
        }

        [Test]
        public void PostMotorTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new MotorTypeModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostMotorType(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.Add(It.IsAny<MotorType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostMotorTypeReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new MotorTypeModel
            {
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostMotorType(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.Add(It.IsAny<MotorType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostMotorTypeReturnsOkWhenModelIsValid()
        {
            var validModel = new MotorTypeModel
            {
                Name = "name",
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostMotorType(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.Add(It.IsAny<MotorType>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateMotorTypeReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new MotorTypeModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateMotorType(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<MotorType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateMotorTypeReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new MotorTypeModel
            {
                Id = 1
            };

            var result = _sut.UpdateMotorType(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<MotorType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateMotorTypeReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new MotorTypeModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateMotorType(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<MotorType>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateMotorTypeReturnsNotFoundWhenModelIsNotFound()
        {
            var invalidModel = new MotorTypeModel
            {
                Id = 1,
                BrandId = 1
            };

            var brand = new Brand();

            _motorTypeRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<MotorType>()))
                .Returns(false);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateMotorType(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<MotorType>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateMotorTypeReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new MotorTypeModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            var brand = new Brand();

            _motorTypeRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<MotorType>()))
                .Returns(true);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateMotorType(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<MotorType>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteMotorTypeReturnsNotFoundWhenMotorTypeIsNotFound()
        {
            MotorType model = null;

            _motorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.DeleteMotorType(1) as NotFoundResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _motorTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<MotorType>()), Times.Never);
        }

        [Test]
        public void DeleteMotorTypeReturnsOkWhenEverythingIsCorrect()
        {
            var model = new MotorType();

            _motorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.DeleteMotorType(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _motorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _motorTypeRepositoryMock.Verify(m => m.Remove(It.IsAny<MotorType>()), Times.Once);
        }
    }
}
