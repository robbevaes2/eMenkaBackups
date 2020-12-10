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

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class ModelControllerTests
    {
        private ModelController _sut;
        private Mock<IModelRepository> _modelRepositoryMock;
        private Mock<IBrandRepository> _brandRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _modelRepositoryMock = new Mock<IModelRepository>();
            _brandRepositoryMock = new Mock<IBrandRepository>();
            _mapperMock = new Mock<IMapper>();
            _sut = new ModelController(_modelRepositoryMock.Object, _brandRepositoryMock.Object, _mapperMock.Object);
        }



        [Test]
        public void GetAllModelsReturnsOkAndListOfAllModelsWhenEverythingIsCorrect()
        {
            var models = new List<Model>();

            _modelRepositoryMock.Setup(m => m.GetAll())
                .Returns(models);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<ModelReturnModel>;
            Assert.That(value, Is.Not.Null);
            _modelRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetModelByIdReturnsNotFoundWhenModelDoesNotExist()
        {
            Model model = null;

            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetModelByIdReturnsOkAndModelWhenEverythingIsCorrect()
        {
            var model = new Model
            {
                Brand = new Brand
                {
                    ExteriorColors = new List<ExteriorColor>(),
                    InteriorColors = new List<InteriorColor>()
                }
            };

            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _mapperMock.Setup(m => m.Map<ModelReturnModel>(It.IsAny<Model>()))
                .Returns(new ModelReturnModel());

            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as ModelReturnModel;
            Assert.That(value, Is.Not.Null);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetModelByBrandIdReturnsNotFoundWhenBrandDoesNotExist()
        {
            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.GetByBrandId(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Model, bool>>>()), Times.Never);
        }

        [Test]
        public void GetModelByBrandIdReturnsOkAndModelWhenEverythingIsCorrect()
        {
            var brand = new Brand();
            var models = new List<Model>();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Model, bool>>>()))
                .Returns(models);
            _mapperMock.Setup(m => m.Map<ModelReturnModel>(It.IsAny<Model>()))
                .Returns(new ModelReturnModel());

            var result = _sut.GetByBrandId(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<ModelReturnModel>;
            Assert.That(value, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Model, bool>>>()), Times.Once);
        }

        [Test]
        public void PostModelReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new ModelModel
            {
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.Add(It.IsAny<Model>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostModelReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new ModelModel
            {
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.Add(It.IsAny<Model>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostModelReturnsOkWhenModelIsValid()
        {
            var validModel = new ModelModel
            {
                Name = "name",
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _mapperMock.Setup(m => m.Map<ModelReturnModel>(It.IsAny<Model>()))
                .Returns(new ModelReturnModel());
            _mapperMock.Setup(m => m.Map<Model>(It.IsAny<ModelModel>()))
                .Returns(new Model());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((ModelReturnModel)result.Value, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.Add(It.IsAny<Model>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateModelReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new ModelModel
            {
                BrandId = 1
            };
            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Model>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateModelReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new ModelModel
            {
                Id = 1,
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Model>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateModelReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new ModelModel
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

            _modelRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Model>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateModelReturnsNotFoundWhenModelIsNotFound()
        {
            var invalidModel = new ModelModel
            {
                Id = 1,
                BrandId = 1
            };

            var brand = new Brand();

            _modelRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Model>()))
                .Returns(false);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Model>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateModelReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new ModelModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            var brand = new Brand();

            _modelRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Model>()))
                .Returns(true);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Model>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteModelReturnsNotFoundWhenModelIsNotFound()
        {
            Model model = null;

            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.Remove(It.IsAny<Model>()), Times.Never);
        }

        [Test]
        public void DeleteModelReturnsOkWhenEverythingIsCorrect()
        {
            var model = new Model();

            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.Remove(It.IsAny<Model>()), Times.Once);
        }
    }
}