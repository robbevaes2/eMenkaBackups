using eMenka.API.Controllers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using AutoMapper;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class CostAllocationControllerTests
    {
        private CostAllocationController _sut;
        private Mock<ICostAllocationRepository> _costAllocationRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _costAllocationRepositoryMock = new Mock<ICostAllocationRepository>();
            _mapperMock= new Mock<IMapper>();
            _sut = new CostAllocationController(_costAllocationRepositoryMock.Object, _mapperMock.Object);
        }


        [Test]
        public void GetAllCostAllocationsReturnsOkAndListOfAllCostAllocationsWhenEverythingIsCorrect()
        {
            var costAllocations = new List<CostAllocation>();

            _costAllocationRepositoryMock.Setup(m => m.GetAll())
                .Returns(costAllocations);

            var result = _sut.GetAllEntities() as OkObjectResult;

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

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetCostAllocationByIdReturnsOkAndCostAllocationWhenEverythingIsCorrect()
        {
            var costAllocation = new CostAllocation();

            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);
            _mapperMock.Setup(m => m.Map<CostAllocationReturnModel>(It.IsAny<CostAllocation>()))
                .Returns(new CostAllocationReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

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

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Add(It.IsAny<CostAllocation>()), Times.Never);
        }

        [Test]
        public void PostCostAllocationReturnsOkWhenModelIsValid()
        {
            var validModel = new CostAllocationModel
            {
                Name = "name"
            };
            _mapperMock.Setup(m => m.Map<CostAllocationReturnModel>(It.IsAny<CostAllocation>()))
                .Returns(new CostAllocationReturnModel());
            _mapperMock.Setup(m => m.Map<CostAllocation>(It.IsAny<CostAllocationModel>()))
                .Returns(new CostAllocation());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((CostAllocationReturnModel)result.Value, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Add(It.IsAny<CostAllocation>()), Times.Once);
        }

        [Test]
        public void UpdateCostAllocationReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CostAllocationModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()),
                Times.Never);
        }

        [Test]
        public void UpdateCostAllocationReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new CostAllocationModel
            {
                Id = 1
            };

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()),
                Times.Never);
        }

        [Test]
        public void UpdateCostAllocationReturnsNotFoundWhenCostAllocationIsNotFound()
        {
            var invalidModel = new CostAllocationModel
            {
                Id = 1
            };

            _costAllocationRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()))
                .Returns(false);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()),
                Times.Once);
        }

        [Test]
        public void UpdateCostAllocationReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new CostAllocationModel
            {
                Id = 1,
                Name = ""
            };

            _costAllocationRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()))
                .Returns(true);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<CostAllocation>()),
                Times.Once);
        }

        [Test]
        public void DeleteCostAllocationReturnsNotFoundWhenCostAllocationIsNotFound()
        {
            CostAllocation costAllocation = null;

            _costAllocationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(costAllocation);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

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

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _costAllocationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _costAllocationRepositoryMock.Verify(m => m.Remove(It.IsAny<CostAllocation>()), Times.Once);
        }
    }
}