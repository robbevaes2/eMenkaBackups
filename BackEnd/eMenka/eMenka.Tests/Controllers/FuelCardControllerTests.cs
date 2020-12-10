using System;
using eMenka.API.Controllers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class FuelCardControllerTests
    {

        private FuelCardController _sut;
        private Mock<IFuelCardRepository> _fuelCardRepositoryMock;
        private Mock<IDriverRepository> _driverRepositoryMock;
        private Mock<IVehicleRepository> _vehicleRepositoryMock;
        private Mock<ICompanyRepository> _companyRepositoryMock;
        private Mock<IMapper> _mapperMock;


        [SetUp]
        public void Init()
        {
            _fuelCardRepositoryMock = new Mock<IFuelCardRepository>();
            _driverRepositoryMock = new Mock<IDriverRepository>();
            _vehicleRepositoryMock = new Mock<IVehicleRepository>();
            _companyRepositoryMock = new Mock<ICompanyRepository>();
            _mapperMock = new Mock<IMapper>();
            _sut = new FuelCardController(_fuelCardRepositoryMock.Object, _driverRepositoryMock.Object, _companyRepositoryMock.Object,
                _vehicleRepositoryMock.Object, _mapperMock.Object);
        }

        [Test]
        public void GetAllFuelCardsReturnsOkAndListOfAllFuelCardsWhenEverythingIsCorrect()
        {
            var fuelCards = new List<FuelCard>();

            _fuelCardRepositoryMock.Setup(m => m.GetAll())
                .Returns(fuelCards);

            var result = _sut.GetAllEntities() as OkObjectResult;

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

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetFuelCardByIdReturnsOkAndFuelCardWhenEverythingIsCorrect()
        {
            var fuelCard = new FuelCard();

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _mapperMock.Setup(m => m.Map<FuelCardReturnModel>(It.IsAny<FuelCard>()))
                .Returns(new FuelCardReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as FuelCardReturnModel;
            Assert.That(value, Is.Not.Null);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetFuelCardsByEndDateReturnsOkAndFuelCardsWhenEverythingIsCorrect()
        {
            var fuelCards = new List<FuelCard>();

            _fuelCardRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()))
                .Returns(fuelCards);
            _mapperMock.Setup(m => m.Map<FuelCardReturnModel>(It.IsAny<FuelCard>()))
                .Returns(new FuelCardReturnModel());
            var result = _sut.GetFuelcardByEndDate(10) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<FuelCardReturnModel>;
            Assert.That(value, Is.Not.Null);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Once);
        }

        [Test]
        public void PostFuelCardReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new FuelCardModel
            {
                DriverId = 1,
                VehicleId = 1,
                CompanyId = 1
            };

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Never);
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

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Never);
        }

        [Test]
        public void PostFuelCardReturnsBadRequestWhenDriverAlreadyExists()
        {
            var validModel = new FuelCardModel
            {
                DriverId = 1
            };

            var driver = new Driver();
            var fuelcards = new List<FuelCard>
            {
                new FuelCard()
            };

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _fuelCardRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()))
                .Returns(fuelcards);

            var result = _sut.PostEntity(validModel) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Once);
        }

        [Test]
        public void PostFuelCardReturnsNotFoundWhenVehicleIsNotFound()
        {
            var validModel = new FuelCardModel
            {
                DriverId = 1,
                VehicleId = 1
            };

            var driver = new Driver();
            Vehicle vehicle = null;

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Once);
        }

        [Test]
        public void PostFuelCardReturnsBadRequestWhenVehicleAlreadyExists()
        {
            var validModel = new FuelCardModel
            {
                DriverId = 1,
                VehicleId = 1
            };

            var driver = new Driver();
            Vehicle vehicle = new Vehicle();
            var fuelcards = new List<FuelCard>
            {
                new FuelCard()
            };

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);
            _fuelCardRepositoryMock.SetupSequence(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()))
                .Returns(new List<FuelCard>())
                .Returns(fuelcards);

            var result = _sut.PostEntity(validModel) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Exactly(2));
        }

        [Test]
        public void PostFuelCardReturnsNotFoundWhenCompanyIsNotFound()
        {
            var validModel = new FuelCardModel
            {
                DriverId = 1,
                VehicleId = 1,
                CompanyId = 1
            };

            var driver = new Driver();
            Vehicle vehicle = new Vehicle();
            Company company = null;

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);
            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Exactly(2));
        }

        [Test]
        public void PostFuelCardReturnsOkWhenModelIsValid()
        {
            var validModel = new FuelCardModel
            {
                DriverId = 1,
                VehicleId = 1,
                CompanyId = 1
            };

            var driver = new Driver();
            var vehicle = new Vehicle();
            var company = new Company();

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);
            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);
            _mapperMock.Setup(m => m.Map<FuelCardReturnModel>(It.IsAny<FuelCard>()))
                .Returns(new FuelCardReturnModel());
            _mapperMock.Setup(m => m.Map<FuelCard>(It.IsAny<FuelCardModel>()))
                .Returns(new FuelCard());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((FuelCardReturnModel)result.Value, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Add(It.IsAny<FuelCard>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Exactly(2));
        }

        [Test]
        public void UpdateFuelCardReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new FuelCardModel
            {
                DriverId = 1,
                VehicleId = 1
            };

            var driver = new Driver();
            var vehicle = new Vehicle();

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Exactly(2));
        }

        [Test]
        public void UpdateFuelCardReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1,
                VehicleId = 1
            };

            var driver = new Driver();
            var vehicle = new Vehicle();

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Exactly(2));
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

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateFuelCardReturnsBadRequestWhenDriverAlreadyExists()
        {
            var validModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1
            };

            var driver = new Driver();
            var fuelcards = new List<FuelCard>
            {
                new FuelCard
                {
                    Id = validModel.Id + 1
                }
            };

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _fuelCardRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()))
                .Returns(fuelcards);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateFuelCardReturnsNotFoundWhenVehicleIsNotFound()
        {
            var validModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1,
                VehicleId = 1
            };

            var driver = new Driver();
            Vehicle vehicle = null;

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateFuelCardReturnsBadRequestWhenVehicleAlreadyExists()
        {
            var validModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1,
                VehicleId = 1
            };

            var driver = new Driver();
            var vehicle = new Vehicle();
            var fuelcards = new List<FuelCard>
            {
                new FuelCard
                {
                    Id = validModel.Id + 1
                }
            };

            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);
            _fuelCardRepositoryMock.SetupSequence(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()))
                .Returns(new List<FuelCard>())
                .Returns(fuelcards);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Never);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Exactly(2));
        }

        [Test]
        public void UpdateFuelCardReturnsNotFoundWhenFuelCardIsNotFound()
        {
            var invalidModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1,
                VehicleId = 1
            };

            var driver = new Driver();
            var vehicle = new Vehicle();

            _fuelCardRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()))
                .Returns(false);
            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Exactly(2));
        }

        [Test]
        public void UpdateFuelCardReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new FuelCardModel
            {
                Id = 1,
                DriverId = 1,
                VehicleId = 1
            };

            var driver = new Driver();
            var vehicle = new Vehicle();

            _fuelCardRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()))
                .Returns(true);
            _driverRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(driver);
            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<FuelCard>()), Times.Once);
            _driverRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<FuelCard, bool>>>()), Times.Exactly(2));
        }

        [Test]
        public void DeleteFuelCardReturnsNotFoundWhenFuelCardIsNotFound()
        {
            FuelCard fuelCard = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

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

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.Remove(It.IsAny<FuelCard>()), Times.Once);
        }
    }
}