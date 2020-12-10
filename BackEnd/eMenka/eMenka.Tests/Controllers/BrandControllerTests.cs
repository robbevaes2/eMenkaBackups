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
    public class BrandControllerTests
    {
        private BrandController _sut;
        private Mock<IBrandRepository> _brandRepositoryMock;
        private Mock<IExteriorColorRepository> _exteriorColorRepositoryMock;
        private Mock<IInteriorColorRepository> _interiorColorRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _brandRepositoryMock = new Mock<IBrandRepository>();
            _interiorColorRepositoryMock = new Mock<IInteriorColorRepository>();
            _exteriorColorRepositoryMock = new Mock<IExteriorColorRepository>();
            _mapperMock = new Mock<IMapper>();
            _sut = new BrandController(_brandRepositoryMock.Object, _exteriorColorRepositoryMock.Object,
                _interiorColorRepositoryMock.Object, _mapperMock.Object);
        }


        [Test]
        public void GetAllBrandsReturnsOkAndListOfAllBrandsWhenEverythingIsCorrect()
        {
            var brands = new List<Brand>();

            _brandRepositoryMock.Setup(m => m.GetAll())
                .Returns(brands);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<BrandReturnModel>;
            Assert.That(value, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetBrandByIdReturnsNotFoundWhenBrandDoesNotExist()
        {
            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetBrandByIdReturnsOkAndBrandWhenEverythingIsCorrect()
        {
            var brand = new Brand
            {
                ExteriorColors = new List<ExteriorColor>(),
                InteriorColors = new List<InteriorColor>()
            };
            var brandReturnModel = new BrandReturnModel();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _mapperMock.Setup(m => m.Map<BrandReturnModel>(brand))
                .Returns(brandReturnModel);

            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as BrandReturnModel;
            Assert.That(value, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _mapperMock.Verify(m => m.Map<BrandReturnModel>(brand), Times.Once);
        }

        [Test]
        public void GetBrandsByNameReturnsOkAndBrandWhenEverythingIsCorrect()
        {
            var brands = new List<Brand>(){new Brand(){Id = 0}};
            var brandReturnModel = new BrandReturnModel();

            _brandRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Brand, bool>>>()))
                .Returns(brands);
            _mapperMock.Setup(m => m.Map<BrandReturnModel>(It.IsAny<Brand>()))
                .Returns(brandReturnModel);

            var result = _sut.GetBrandsByName("name") as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<BrandReturnModel>;
            Assert.That(value, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Brand, bool>>>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Brand, bool>>>()), Times.Exactly(brands.Count));
        }

        [Test]
        public void PostBrandReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new BrandModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.Add(It.IsAny<Brand>()), Times.Never);
        }

        [Test]
        public void PostBrandReturnsOkWhenModelIsValid()
        {
            var validModel = new BrandModel
            {
                Name = "name",
                ExteriorColorIds = new[] { 1 },
                InteriorColorIds = new[] { 1 }
            };

            _exteriorColorRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(new ExteriorColor());
            _interiorColorRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(new InteriorColor());
            _mapperMock.Setup(m => m.Map<Brand>(It.IsAny<BrandModel>()))
                .Returns(new Brand());
            _mapperMock.Setup(m => m.Map<BrandReturnModel>(It.IsAny<Brand>()))
                .Returns(new BrandReturnModel());

            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((BrandReturnModel)result.Value, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.Add(It.IsAny<Brand>()), Times.Once);
            _mapperMock.Verify(m => m.Map<Brand>(It.IsAny<BrandModel>()), Times.Once);
            _mapperMock.Verify(m => m.Map<BrandReturnModel>(It.IsAny<Brand>()), Times.Once);
        }

        [Test]
        public void UpdateBrandReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new BrandModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Brand>()), Times.Never);
        }

        [Test]
        public void UpdateBrandReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new BrandModel
            {
                Id = 1
            };

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Brand>()), Times.Never);
        }

        [Test]
        public void UpdateBrandReturnsNotFoundWhenBrandIsNotFound()
        {
            var invalidModel = new BrandModel
            {
                Id = 1,
                ExteriorColorIds = new[] { 1 },
                InteriorColorIds = new[] { 1 }
            };

            _brandRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Brand>()))
                .Returns(false);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Brand>()), Times.Once);
        }

        [Test]
        public void UpdateBrandReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new BrandModel
            {
                Id = 1,
                Name = "",
                ExteriorColorIds = new[] { 1 },
                InteriorColorIds = new[] { 1 }
            };

            _brandRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Brand>()))
                .Returns(true);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Brand>()), Times.Once);
        }

        [Test]
        public void DeleteBrandReturnsNotFoundWhenDoorTypeIsNotFound()
        {
            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.Remove(It.IsAny<Brand>()), Times.Never);
        }

        [Test]
        public void DeleteBrandReturnsOkWhenEverythingIsCorrect()
        {
            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.Remove(It.IsAny<Brand>()), Times.Once);
        }
    }
}