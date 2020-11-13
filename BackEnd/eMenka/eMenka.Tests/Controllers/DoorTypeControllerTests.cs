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
            var doorTypes = new List<DoorType>
            {
                new DoorType
                {
                    Id = 1,
                    Name = "name"
                }
            };

            _doorTypeRepositoryMock.Setup(m => m.GetAll())
                .Returns(doorTypes);

            var result = _sut.GetAllDoorTypes() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<DoorTypeReturnModel>;
            Assert.That(value, Is.Not.Null);
            _doorTypeRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }
    }
}
