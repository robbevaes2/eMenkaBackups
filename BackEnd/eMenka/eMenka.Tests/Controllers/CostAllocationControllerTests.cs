﻿using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Controllers;
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
    public class CostAllocationControllerTests
    {
        private CostAllocationController _sut;
        private Mock<ICostAllocationRepository> _costAllocationRepositoryMock;

        [SetUp]
        public void Init()
        {
            _costAllocationRepositoryMock = new Mock<ICostAllocationRepository>();
            _sut = new CostAllocationController(_costAllocationRepositoryMock.Object);
        }

        [Test]
        public void GetAllCostAllocationsReturnsOkAndListOfAllCostAllocationsWhenEverythingIsCorrect()
        {
            var costAllocations = new List<CostAllocation>();

            _costAllocationRepositoryMock.Setup(m => m.GetAll())
                .Returns(costAllocations);

            var result = _sut.GetAllCostAllocations() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<CostAllocationReturnModel>;
            Assert.That(value, Is.Not.Null);
            _costAllocationRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetCostAllocationByIdReturnsNotFoundWhenCostAllocationDoesNotExist()
        {
            CostAllocation costAllocation = null;

            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.GetCostAllocationById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetCostAllocationByIdReturnsOkAndCostAllocationWhenEverythingIsCorrect()
        {
            var costAllocation = new CostAllocation();

            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.GetCostAllocationById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as CostAllocationReturnModel;
            Assert.That(value, Is.Not.Null);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostCostAllocationReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CostAllocationModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostCostAllocation(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Add(It.IsAny<CostAllocation>()), Times.Never);
        }

        [Test]
        public void PostCostAllocationReturnsOkWhenModelIsValid()
        {
            var validModel = new CostAllocationModel()
            {
                Name = "name"
            };

            var result = _sut.PostCostAllocation(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Add(It.IsAny<CostAllocation>()), Times.Once);
        }

        [Test]
        public void UpdateCostAllocationReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CostAllocationModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateCostAllocation(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()), Times.Never);
        }

        [Test]
        public void UpdateCostAllocationReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new CostAllocationModel()
            {
                Id = 1
            };

            var result = _sut.UpdateCostAllocation(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()), Times.Never);
        }

        [Test]
        public void UpdateCostAllocationReturnsNotFoundWhenCostAllocationIsNotFound()
        {
            var invalidModel = new CostAllocationModel()
            {
                Id = 1
            };

            _costAllocationRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()))
                .Returns(false);

            var result = _sut.UpdateCostAllocation(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()), Times.Once);
        }

        [Test]
        public void UpdateCostAllocationReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new CostAllocationModel()
            {
                Id = 1,
                Name = ""
            };

            _costAllocationRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()))
                .Returns(true);

            var result = _sut.UpdateCostAllocation(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()), Times.Once);
        }

        [Test]
        public void DeleteCostAllocationReturnsNotFoundWhenCostAllocationIsNotFound()
        {
            CostAllocation costAllocation = null;

            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.DeleteCostAllocation(1) as NotFoundResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.Remove(It.IsAny<CostAllocation>()), Times.Never);
        }

        [Test]
        public void DeleteCostAllocationReturnsOkWhenEverythingIsCorrect()
        {
            var costAllocation = new CostAllocation();

            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.DeleteCostAllocation(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.Remove(It.IsAny<CostAllocation>()), Times.Once);
        }
    }
}