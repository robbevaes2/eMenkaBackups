using System.Collections.Generic;
using eMenka.API.Controllers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class FuelCardControllerTests
    {
        [SetUp]
        public void Init()
        {
            _fuelCardRepositoryMock = new Mock<IFuelCardRepository>();
            _driverRepositoryMock = new Mock<IDriverRepository>();
            _sut = new FuelCardController(_fuelCardRepositoryMock.Object, _driverRepositoryMock.Object);
        }

        private FuelCardController _sut;
        private Mock<IFuelCardRepository> _fuelCardRepositoryMock;
        private Mock<IDriverRepository> _driverRepositoryMock;

        [Test]
        public void GetAllFuelCardsReturnsOkAndListOfAllFuelCardsWhenEverythingIsCorrect()
        {
            var fuelCards = new List<FuelCard>();

            _fuelCardRepositoryMock.Setup(m => m.GetAll())
                .Returns(fuelCards);

            var result = _sut.GetAllFuelCards() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<FuelCardReturnModel>;
            Assert.That(value, Is.Not.Null);
            _fuelCardRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetFuelCardByIdReturnsNotFoundWhenFuelCardDoesNotExist()
        {
            FuelCard fuelCard = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.GetFuelCardById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetFuelCardByIdReturnsOkAndFuelCardWhenEverythingIsCorrect()
        {
            var fuelCard = new FuelCard();

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.GetFuelCardById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as FuelCardReturnModel;
            Assert.That(value, Is.Not.Null);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostFuelCardReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new FuelCardModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostFuelCard(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostFuelCardReturnsNotFoundWhenDriverIsNotFound()
        {
            var validModel = new FuelCardModel
            {
                DriverId = 1
            };

            Driver driver = null;

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.PostFuelCard(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostFuelCardReturnsOkWhenModelIsValid()
        {
            var validModel = new FuelCardModel
            {
                DriverId = 1
            };

            var driver = new Driver();

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.PostFuelCard(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateFuelCardReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new FuelCardModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateFuelCard(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateFuelCardReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1
            };

            var result = _sut.UpdateFuelCard(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateFuelCardReturnsNotFoundWhenDriverIsNotFound()
        {
            var validModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1
            };

            Driver driver = null;

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.UpdateFuelCard(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateFuelCardReturnsNotFoundWhenFuelCardIsNotFound()
        {
            var invalidModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1
            };

            var driver = new Driver();

            _fuelCardRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()))
                .Returns(false);
            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.UpdateFuelCard(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateFuelCardReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1
            };

            var driver = new Driver();

            _fuelCardRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()))
                .Returns(true);
            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);

            var result = _sut.UpdateFuelCard(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteFuelCardReturnsNotFoundWhenFuelCardIsNotFound()
        {
            FuelCard fuelCard = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.DeleteFuelCard(1) as NotFoundResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Remove(It.IsAny<FuelCard>()), Times.Never);
        }

        [Test]
        public void DeleteFuelCardReturnsOkWhenEverythingIsCorrect()
        {
            var fuelCard = new FuelCard();

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.DeleteFuelCard(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Remove(It.IsAny<FuelCard>()), Times.Once);
        }
    }
}