﻿using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Controllers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

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

        [SetUp]
        public void Init()
        {
            _recordRepositoryMock = new Mock<IRecordRepository>();
            _fuelCardRepositoryMock = new Mock<IFuelCardRepository>();
            _corporationRepositoryMock = new Mock<ICorporationRepository>();
            _costAllocationRepositoryMock = new Mock<ICostAllocationRepository>();

            _sut = new RecordController(_recordRepositoryMock.Object, _fuelCardRepositoryMock.Object, _corporationRepositoryMock.Object, _costAllocationRepositoryMock.Object);
        }

        [Test]
        public void GetAllRecordsReturnsOkAndListOfAllRecordsWhenEverythingIsCorrect()
        {
            var records = new List<Record>();

            _recordRepositoryMock.Setup(m => m.GetAll())
                .Returns(records);

            var result = _sut.GetAllRecords() as OkObjectResult;

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

            var result = _sut.GetRecordById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _recordRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetRecordByIdReturnsOkAndRecordWhenEverythingIsCorrect()
        {
            var record = new Record();

            _recordRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(record);

            var result = _sut.GetRecordById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as RecordReturnModel;
            Assert.That(value, Is.Not.Null);
            _recordRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostRecordReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new RecordModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostRecord(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostRecordReturnsNotFoundWhenFuelCardIsNotFound()
        {
            var validModel = new RecordModel()
            {
                FuelCardId = 1
            };

            FuelCard fuelCard = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.PostRecord(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostRecordReturnsNotFoundWhenCorporationIsNotFound()
        {
            var validModel = new RecordModel()
            {
                FuelCardId = 1,
                CorporationId = 1
            };

            FuelCard fuelCard = new FuelCard();
            Corporation corporation = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);

            var result = _sut.PostRecord(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostRecordReturnsNotFoundWhenCostAllocationIsNotFound()
        {
            var validModel = new RecordModel()
            {
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            FuelCard fuelCard = new FuelCard();
            Corporation corporation = new Corporation();
            CostAllocation costAllocation = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.PostRecord(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostFuelCardReturnsOkWhenModelIsValid()
        {
            var validModel = new RecordModel()
            {
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            FuelCard fuelCard = new FuelCard();
            Corporation corporation = new Corporation();
            CostAllocation costAllocation = new CostAllocation();

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.PostRecord(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Add(It.IsAny<Record>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateRecordReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new RecordModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateRecord(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateRecordReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new RecordModel()
            {
                Id = 1
            };

            var result = _sut.UpdateRecord(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateRecordReturnsNotFoundWhenFuelCardIsNotFound()
        {
            var validModel = new RecordModel()
            {
                Id = 1,
                FuelCardId = 1
            };

            FuelCard fuelCard = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.UpdateRecord(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateRecordReturnsNotFoundWhenCorporationIsNotFound()
        {
            var validModel = new RecordModel()
            {
                Id = 1,
                FuelCardId = 1,
                CorporationId = 1
            };

            FuelCard fuelCard = new FuelCard();
            Corporation corporation = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);

            var result = _sut.UpdateRecord(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateRecordReturnsNotFoundWhenCostAllocationIsNotFound()
        {
            var validModel = new RecordModel()
            {
                Id = 1,
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            FuelCard fuelCard = new FuelCard();
            Corporation corporation = new Corporation();
            CostAllocation costAllocation = null;

            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.UpdateRecord(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Never);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateFuelCardReturnsNotFoundWhenFuelCardIsNotFound()
        {
            var validModel = new RecordModel()
            {
                Id = 1,
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            FuelCard fuelCard = new FuelCard();
            Corporation corporation = new Corporation();
            CostAllocation costAllocation = new CostAllocation();

            _recordRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()))
                .Returns(false); 
            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.UpdateRecord(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateFuelCardReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new RecordModel()
            {
                Id = 1,
                FuelCardId = 1,
                CorporationId = 1,
                CostAllocationId = 1
            };

            FuelCard fuelCard = new FuelCard();
            Corporation corporation = new Corporation();
            CostAllocation costAllocation = new CostAllocation();

            _recordRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()))
                .Returns(true);
            _fuelCardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);
            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.UpdateRecord(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Record>()), Times.Once);
            _fuelCardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteRecordReturnsNotFoundWhenRecordIsNotFound()
        {
            Record record = null;

            _recordRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(record);

            var result = _sut.DeleteRecord(1) as NotFoundResult;

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

            var result = _sut.DeleteRecord(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _recordRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.Remove(It.IsAny<Record>()), Times.Once);
        }
    }
}