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
    public class SerieControllerTests
    {
        private SerieController _sut;
        private Mock<ISerieRepository> _serieRepositoryMock;
        private Mock<IBrandRepository> _brandRepositoryMock;

        [SetUp]
        public void Init()
        {
            _serieRepositoryMock = new Mock<ISerieRepository>();
            _brandRepositoryMock = new Mock<IBrandRepository>();
            _sut = new SerieController(_serieRepositoryMock.Object, _brandRepositoryMock.Object);
        }

        [Test]
        public void GetAllSeriesReturnsOkAndListOfAllSeriesWhenEverythingIsCorrect()
        {
            var series = new List<Series>();

            _serieRepositoryMock.Setup(m => m.GetAll())
                .Returns(series);

            var result = _sut.GetAllSeries() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<SerieReturnModel>;
            Assert.That(value, Is.Not.Null);
            _serieRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetSerieByIdReturnsNotFoundWhenSerieDoesNotExist()
        {
            Series series = null;

            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            var result = _sut.GetSerieById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetSerieByIdReturnsOkAndSerieWhenEverythingIsCorrect()
        {
            var serie = new Series
            {
                Brand = new Brand()
            };

            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(serie);

            var result = _sut.GetSerieById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as SerieReturnModel;
            Assert.That(value, Is.Not.Null);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetSeriesByBrandIdReturnsNotFoundWhenBrandDoesNotExist()
        {
            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.GetSeriesByBrandId(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Series, bool>>>()), Times.Never);
        }

        [Test]
        public void GetSeriesByBrandIdReturnsOkAndSerieWhenEverythingIsCorrect()
        {
            var brand = new Brand();
            var series = new List<Series>();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _serieRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Series, bool>>>()))
                .Returns(series);

            var result = _sut.GetSeriesByBrandId(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<SerieReturnModel>;
            Assert.That(value, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Series, bool>>>()), Times.Once);
        }

        [Test]
        public void GetSeriesByNameReturnsOkAndSerieWhenEverythingIsCorrect()
        {
            var series = new List<Series>();

            _serieRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Series, bool>>>()))
                .Returns(series);

            var result = _sut.GetSeriesByName("name") as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<SerieReturnModel>;
            Assert.That(value, Is.Not.Null);
            _serieRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Series, bool>>>()), Times.Once);
        }

        [Test]
        public void PostSerieReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new SerieModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostSerie(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Add(It.IsAny<Series>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostSerieReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new SerieModel
            {
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostSerie(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Add(It.IsAny<Series>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostSerieReturnsOkWhenModelIsValid()
        {
            var validModel = new SerieModel
            {
                Name = "name",
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostSerie(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Add(It.IsAny<Series>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateSerieReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new SerieModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateSerie(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Series>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateSerieReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new SerieModel
            {
                Id = 1
            };

            var result = _sut.UpdateSerie(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Series>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateSerieReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new SerieModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateSerie(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Series>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateSerieReturnsNotFoundWhenSerieIsNotFound()
        {
            var invalidModel = new SerieModel
            {
                Id = 1,
                BrandId = 1
            };

            var brand = new Brand();

            _serieRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Series>()))
                .Returns(false);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateSerie(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Series>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateSerieReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new SerieModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            var brand = new Brand();

            _serieRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Series>()))
                .Returns(true);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateSerie(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Series>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteSerieReturnsNotFoundWhenSerieIsNotFound()
        {
            Series series = null;

            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            var result = _sut.DeleteSerie(1) as NotFoundResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.Remove(It.IsAny<Series>()), Times.Never);
        }

        [Test]
        public void DeleteSerieReturnsOkWhenEverythingIsCorrect()
        {
            var serie = new Series();

            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(serie);

            var result = _sut.DeleteSerie(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.Remove(It.IsAny<Series>()), Times.Once);
        }
    }
}
