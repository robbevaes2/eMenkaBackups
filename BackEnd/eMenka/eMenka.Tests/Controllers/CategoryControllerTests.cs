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
    public class CategoryControllerTests
    {
        private CategoryController _sut;
        private Mock<ICategoryRepository> _categoryRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _categoryRepositoryMock = new Mock<ICategoryRepository>();
            _mapperMock= new Mock<IMapper>();
            _sut = new CategoryController(_categoryRepositoryMock.Object, _mapperMock.Object);
        }


        [Test]
        public void GetAllCatgeoriesReturnsOkAndListOfAllCatgeoriesWhenEverythingIsCorrect()
        {
            var categories = new List<Category>();

            _categoryRepositoryMock.Setup(m => m.GetAll())
                .Returns(categories);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<CategoryReturnModel>;
            Assert.That(value, Is.Not.Null);
            _categoryRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetCategroyByIdReturnsNotFoundWhenCategoryDoesNotExist()
        {
            Category category = null;

            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetCategoryByIdReturnsOkAndCategoryWhenEverythingIsCorrect()
        {
            var category = new Category();

            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);
            _mapperMock.Setup(m => m.Map<CategoryReturnModel>(It.IsAny<Category>()))
                .Returns(new CategoryReturnModel());

            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as CategoryReturnModel;
            Assert.That(value, Is.Not.Null);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetCategoriesByNameReturnsOkAndCategoriesWhenEverythingIsCorrect()
        {
            var categories = new List<Category>();

            _categoryRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Category, bool>>>()))
                .Returns(categories);
            _mapperMock.Setup(m => m.Map<CategoryReturnModel>(It.IsAny<Category>()))
                .Returns(new CategoryReturnModel());

            var result = _sut.GetCategoryByName("name") as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<CategoryReturnModel>;
            Assert.That(value, Is.Not.Null);
            _categoryRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Category, bool>>>()), Times.Once);
        }

        [Test]
        public void PostCategoryReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CategoryModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _categoryRepositoryMock.Verify(m => m.Add(It.IsAny<Category>()), Times.Never);
        }

        [Test]
        public void PostCategoryReturnsOkWhenModelIsValid()
        {
            var validModel = new CategoryModel
            {
                Name = "name"
            };
            _mapperMock.Setup(m => m.Map<Category>(It.IsAny<CategoryModel>()))
                .Returns(new Category());
            _mapperMock.Setup(m => m.Map<CategoryReturnModel>(It.IsAny<Category>()))
                .Returns(new CategoryReturnModel());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((CategoryReturnModel)result.Value, Is.Not.Null);

            _categoryRepositoryMock.Verify(m => m.Add(It.IsAny<Category>()), Times.Once);
        }

        [Test]
        public void UpdateCategoryReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CategoryModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _categoryRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Category>()), Times.Never);
        }

        [Test]
        public void UpdateCategoryReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new CategoryModel
            {
                Id = 1
            };

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _categoryRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Category>()), Times.Never);
        }

        [Test]
        public void UpdateCategoryReturnsNotFoundWhenDoorTypeIsNotFound()
        {
            var invalidModel = new CategoryModel
            {
                Id = 1
            };

            _categoryRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Category>()))
                .Returns(false);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _categoryRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Category>()), Times.Once);
        }

        [Test]
        public void UpdateCategoryReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new CategoryModel
            {
                Id = 1,
                Name = ""
            };

            _categoryRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Category>()))
                .Returns(true);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _categoryRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Category>()), Times.Once);
        }

        [Test]
        public void DeleteCategoryReturnsNotFoundWhenCategoryIsNotFound()
        {
            Category category = null;

            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.Remove(It.IsAny<Category>()), Times.Never);
        }

        [Test]
        public void DeleteCategoryReturnsOkWhenEverythingIsCorrect()
        {
            var category = new Category();

            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.Remove(It.IsAny<Category>()), Times.Once);
        }
    }
}