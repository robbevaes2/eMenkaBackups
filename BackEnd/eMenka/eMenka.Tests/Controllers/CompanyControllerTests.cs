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
    public class CompanyControllerTests
    {
        [SetUp]
        public void Init()
        {
            _companyRepositoryMock = new Mock<ICompanyRepository>();
            _mapperMock = new Mock<IMapper>();
            _sut = new CompanyController(_companyRepositoryMock.Object, _mapperMock.Object);
        }

        private CompanyController _sut;
        private Mock<ICompanyRepository> _companyRepositoryMock;
        private Mock<IMapper> _mapperMock;


        [Test]
        public void GetAllCompaniesReturnsOkAndListOfAllCompaniesWhenEverythingIsCorrect()
        {
            var companies = new List<Company>();

            _companyRepositoryMock.Setup(m => m.GetAll())
                .Returns(companies);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<CompanyReturnModel>;
            Assert.That(value, Is.Not.Null);
            _companyRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetCompaniesByIdReturnsNotFoundWhenCompanyDoesNotExist()
        {
            Company company = null;

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetCompanyByIdReturnsOkAndCompanyWhenEverythingIsCorrect()
        {
            var company = new Company();

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);
            _mapperMock.Setup(m => m.Map<CompanyReturnModel>(It.IsAny<Company>()))
                .Returns(new CompanyReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as CompanyReturnModel;
            Assert.That(value, Is.Not.Null);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostCompanyReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CompanyModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Add(It.IsAny<Company>()), Times.Never);
        }

        [Test]
        public void PostCompanyReturnsOkWhenModelIsValid()
        {
            var validModel = new CompanyModel
            {
                Name = "name"
            };
            _mapperMock.Setup(m => m.Map<CompanyReturnModel>(It.IsAny<Company>()))
                .Returns(new CompanyReturnModel());
            _mapperMock.Setup(m => m.Map<Company>(It.IsAny<CompanyModel>()))
                .Returns(new Company());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((CompanyReturnModel)result.Value, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Add(It.IsAny<Company>()), Times.Once);
        }

        [Test]
        public void UpdateCompanyReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CompanyModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()), Times.Never);
        }

        [Test]
        public void UpdateCompanyReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new CompanyModel
            {
                Id = 1
            };

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()), Times.Never);
        }

        [Test]
        public void UpdateCompanyReturnsNotFoundWhenCompanyIsNotFound()
        {
            var invalidModel = new CompanyModel
            {
                Id = 1
            };

            _companyRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()))
                .Returns(false);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()), Times.Once);
        }

        [Test]
        public void UpdateCompanyReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new CompanyModel
            {
                Id = 1,
                Name = ""
            };

            _companyRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()))
                .Returns(true);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()), Times.Once);
        }

        [Test]
        public void DeleteCompanyReturnsNotFoundWhenCompanyIsNotFound()
        {
            Company company = null;

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.Remove(It.IsAny<Company>()), Times.Never);
        }

        [Test]
        public void DeleteCompanyReturnsOkWhenEverythingIsCorrect()
        {
            var company = new Company();

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.Remove(It.IsAny<Company>()), Times.Once);
        }
    }
}