using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using eMenka.API.Controllers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
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
    public class CorporationControllerTests
    {
        private CorporationController _sut;
        private Mock<ICorporationRepository> _corporationRepositoryMock;
        private Mock<ICompanyRepository> _companyRepositoryMock;

        [SetUp]
        public void Init()
        {
            _corporationRepositoryMock = new Mock<ICorporationRepository>();
            _companyRepositoryMock = new Mock<ICompanyRepository>();
            _sut = new CorporationController(_corporationRepositoryMock.Object, _companyRepositoryMock.Object);
        }

        [Test]
        public void GetAllCorporationsReturnsOkAndListOfAllCorporationsWhenEverythingIsCorrect()
        {
            var corporations = new List<Corporation>();

            _corporationRepositoryMock.Setup(m => m.GetAll())
                .Returns(corporations);

            var result = _sut.GetAllCorporations() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<CorporationReturnModel>;
            Assert.That(value, Is.Not.Null);
            _corporationRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetCorporationByIdReturnsNotFoundWhenCorporationDoesNotExist()
        {
            Corporation corporation = null;

            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);

            var result = _sut.GetCorporationById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetCorporationByIdReturnsOkAndCorporationWhenEverythingIsCorrect()
        {
            var corporation = new Corporation();

            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);

            var result = _sut.GetCorporationById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as CorporationReturnModel;
            Assert.That(value, Is.Not.Null);
            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostCorporationReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CorporationModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostCorporation(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.Add(It.IsAny<Corporation>()), Times.Never);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostCorporationReturnsNotFoundWhenCompanyIsNotFound()
        {
            var validModel = new CorporationModel()
            {
                Name = "",
                CompanyId = 1
            };

            Company company = null;

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.PostCorporation(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.Add(It.IsAny<Corporation>()), Times.Never);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostCorporationReturnsOkWhenModelIsValid()
        {
            var validModel = new CorporationModel()
            {
                Name = "name",
                CompanyId = 1
            };

            var company = new Company();

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.PostCorporation(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.Add(It.IsAny<Corporation>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateCorporationReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CorporationModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateCorporation(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Corporation>()), Times.Never);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateCorporationReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new CorporationModel()
            {
                Id = 1,
                CompanyId = 1
            };

            var result = _sut.UpdateCorporation(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Corporation>()), Times.Never);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateCorporationReturnsNotFoundWhenCompanyIsNotFound()
        {
            var validModel = new CorporationModel()
            {
                Id = 1,
                Name = "",
                CompanyId = 1
            };

            Company company = null;

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.UpdateCorporation(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Corporation>()), Times.Never);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateCorporationReturnsNotFoundWhenCorporationIsNotFound()
        {
            var invalidModel = new CorporationModel()
            {
                Id = 1,
                CompanyId = 1
            };

            var company = new Company();

            _corporationRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Corporation>()))
                .Returns(false);
            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.UpdateCorporation(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Corporation>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateCorporationReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new CorporationModel()
            {
                Id = 1,
                Name = "",
                CompanyId = 1
            };

            var company = new Company();

            _corporationRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Corporation>()))
                .Returns(true);
            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.UpdateCorporation(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Corporation>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteCorporationReturnsNotFoundWhenCorporationIsNotFound()
        {
            Corporation corporation = null;

            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);

            var result = _sut.DeleteCorporation(1) as NotFoundResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.Remove(It.IsAny<Corporation>()), Times.Never);
        }

        [Test]
        public void DeleteCorporationReturnsOkWhenEverythingIsCorrect()
        {
            var corporation = new Corporation();

            _corporationRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(corporation);

            var result = _sut.DeleteCorporation(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _corporationRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _corporationRepositoryMock.Verify(m => m.Remove(It.IsAny<Corporation>()), Times.Once);
        }

    }
}
