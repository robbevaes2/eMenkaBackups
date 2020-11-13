using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Controllers;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class DoorTypeControllerTests
    {
        private DoorTypeController _sut;
        private Mock<IDoorTypeRepository> _doorTypeRepositoryMock;

        [SetUp]
        public void Init()
        {
            _doorTypeRepositoryMock = new Mock<IDoorTypeRepository>();
            _sut = new DoorTypeController(_doorTypeRepositoryMock.Object);
        }

        [Test]
        public void GetAllDoorTypesReturnsBadRequestWhenRepositoryReturnsNull()
        {
            List<DoorType> doorTypes = null;
            _doorTypeRepositoryMock.Setup(m => m.GetAll())
                .Returns(doorTypes);

            var result = _sut.GetAllDoorTypes() as BadRequestResult;

            Assert.That(result, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetAllDoorTypesReturnsOkAndListOfAllDoortypesWhenEverythingIsCorrect()
        {
            var doorTypes = new List<DoorType>();

            _doorTypeRepositoryMock.Setup(m => m.GetAll())
                .Returns(doorTypes);

            var result = _sut.GetAllDoorTypes() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<DoorTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetDoorTypeByIdReturnsBadRequestWhenRepoReturnsNull()
        {
            DoorType doorType = null;

            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);

            var result = _sut.GetDoorTypeById(0) as BadRequestResult;

            Assert.That(result, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetDoorTypeByIdReturnsOkAndDoorTypeWhenEverythingIsCorrect()
        {
            var doorType = new DoorType();

            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);

            var result = _sut.GetDoorTypeById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as DoorTypeReturnModel;
            Assert.That(value, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }
    }
}
