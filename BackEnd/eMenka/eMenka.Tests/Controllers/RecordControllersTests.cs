using eMenka.API.Controllers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using eMenka.API.Models.VehicleModels.ReturnModels;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class RecordControllersTests
    {
        private RecordController _sut;
        private Mock<IRecordRepository> _recordRepositoryMock;
        private Mock<IFuelCardRepository> _fuelCardRepositoryMock;
        private Mock<ICorporationRepository> _corporationRepositoryMock;
        private Mock<ICostAllocationRepository> _costAllocationRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _recordRepositoryMock = new Mock<IRecordRepository>();
            _fuelCardRepositoryMock = new Mock<IFuelCardRepository>();
            _corporationRepositoryMock = new Mock<ICorporationRepository>();
            _costAllocationRepositoryMock = new Mock<ICostAllocationRepository>();
            _mapperMock = new Mock<IMapper>();

            _sut = new RecordController(_recordRepositoryMock.Object, _fuelCardRepositoryMock.Object,
                _corporationRepositoryMock.Object, _costAllocationRepositoryMock.Object, _mapperMock.Object);
        }



        [Test]
        public void GetAllRecordsReturnsOkAndListOfAllRecordsWhenEverythingIsCorrect()
        {
            var records = new List<Record>();

            _recordRepositoryMock.Setup(m => m.GetAll())
                .Returns(records);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<RecordReturnModel>;
            Assert.That(value, Is.Not.Null);
            _recordRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetRecordByIdReturnsNotFoundWhenRecordDoesNotExist()
        {
            Record record = null;

            _recordRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(record);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _recordRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetRecordByIdReturnsOkAndRecordWhenEverythingIsCorrect()
        {
            var record = new Record();

            _recordRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(record);
            _mapperMock.Setup(m => m.Map<RecordReturnModel>(It.IsAny<Record>()))
                .Returns(new RecordReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as RecordReturnModel;
            Assert.That(value, Is.Not.Null);
            _recordRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetRecordsByEndDateReturnsOkAndRecordsWhenEverythingIsCorrect()
        {
            var records = new List<Record>();

            _recordRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()))
                .Returns(records);

            _mapperMock.Setup(m => m.Map<RecordReturnModel>(It.IsAny<Record>()))
                .Returns(new RecordReturnModel());

            var result = _sut.GetRecordByEndDate(10) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<RecordReturnModel>;
            Assert.That(value, Is.Not.Null);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Once);
        }

        [Test]
        public void PostRecordReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new RecordModel
            {
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            var costAllocation = new CostAllocation();

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Once);
        }

        [Test]
        public void PostRecordReturnsNotFoundWhenFuelCardIsNotFound()
        {
            var validModel = new RecordModel
            {
                FuelCardId = 1
            };

            FuelCard fuelCard = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Never);
        }

        [Test]
        public void PostRecordReturnsNotFoundWhenCorporationIsNotFound()
        {
            var validModel = new RecordModel
            {
                FuelCardId = 1,
                CorporationId = 1
            };

            var fuelCard = new FuelCard();
            Corporation corporation = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Never);
        }

        [Test]
        public void PostRecordReturnsNotFoundWhenCostAllocationIsNotFound()
        {
            var validModel = new RecordModel
            {
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            CostAllocation costAllocation = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.PostEntity(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Never);
        }

        [Test]
        public void PostRecordReturnsBadRequestWhenFuelCardAlreadyExists()
        {
            var validModel = new RecordModel
            {
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            var costAllocation = new CostAllocation();
            var records = new List<Record>
            {
                new Record()
            };

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);
            _recordRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()))
                .Returns(records);

            var result = _sut.PostEntity(validModel) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Once);
        }

        [Test]
        public void PostRecordReturnsOkWhenModelIsValid()
        {
            var validModel = new RecordModel
            {
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            var costAllocation = new CostAllocation();

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);
            _mapperMock.Setup(m => m.Map<RecordReturnModel>(It.IsAny<Record>()))
                .Returns(new RecordReturnModel());
            _mapperMock.Setup(m => m.Map<Record>(It.IsAny<RecordModel>()))
                .Returns(new Record());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((RecordReturnModel)result.Value, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateRecordReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new RecordModel
            {
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            var costAllocation = new CostAllocation();

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateRecordReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var validModel = new RecordModel
            {
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            var costAllocation = new CostAllocation();

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.UpdateEntity(validModel, validModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateRecordReturnsNotFoundWhenFuelCardIsNotFound()
        {
            var validModel = new RecordModel
            {
                Id = 1,
                FuelCardId = 1
            };

            FuelCard fuelCard = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateRecordReturnsNotFoundWhenCorporationIsNotFound()
        {
            var validModel = new RecordModel
            {
                Id = 1,
                FuelCardId = 1,
                CorporationId = 1
            };

            var fuelCard = new FuelCard();
            Corporation corporation = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateRecordReturnsNotFoundWhenCostAllocationIsNotFound()
        {
            var validModel = new RecordModel
            {
                Id = 1,
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            CostAllocation costAllocation = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateRecordReturnsBadRequestWhenFuelCardAlreadyExistsAndIsntFromUpdatingRecord()
        {
            var validModel = new RecordModel
            {
                Id = 1,
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            var costAllocation = new CostAllocation();
            var records = new List<Record>
            {
                new Record
                {
                    Id = validModel.Id + 1
                }
            };

            _recordRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()))
                .Returns(true);
            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);
            _recordRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()))
                .Returns(records);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateRecordReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new RecordModel
            {
                Id = 1,
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            var fuelCard = new FuelCard();
            var corporation = new Corporation();
            var costAllocation = new CostAllocation();

            _recordRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()))
                .Returns(true);
            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Record, bool>>>()), Times.Once);
        }

        [Test]
        public void DeleteRecordReturnsNotFoundWhenRecordIsNotFound()
        {
            Record record = null;

            _recordRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(record);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Remove(It.IsAny<Record>()), Times.Never);
        }

        [Test]
        public void DeleteRecordReturnsOkWhenEverythingIsCorrect()
        {
            var record = new Record();

            _recordRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(record);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Remove(It.IsAny<Record>()), Times.Once);
        }
    }
}