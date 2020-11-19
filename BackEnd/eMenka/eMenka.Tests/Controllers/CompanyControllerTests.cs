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
    public class CompanyControllerTests
    {
        private CompanyController _sut;
        private Mock<ICompanyRepository> _companyRepositoryMock;

        [SetUp]
        public void Init()
        {
            _companyRepositoryMock = new Mock<ICompanyRepository>();
            _sut = new CompanyController(_companyRepositoryMock.Object);
        }

        [Test]
        public void GetAllCompaniesReturnsOkAndListOfAllCompaniesWhenEverythingIsCorrect()
        {
            var companies = new List<Company>();

            _companyRepositoryMock.Setup(m => m.GetAll())
                .Returns(companies);

            var result = _sut.GetAllCompanies() as OkObjectResult;

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

            var result = _sut.GetCompanyById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetCompanyByIdReturnsOkAndCompanyWhenEverythingIsCorrect()
        {
            var company = new Company();

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.GetCompanyById(0) as OkObjectResult;

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

            var result = _sut.PostCompany(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Add(It.IsAny<Company>()), Times.Never);
        }

        [Test]
        public void PostCompanyReturnsOkWhenModelIsValid()
        {
            var validModel = new CompanyModel()
            {
                Name = "name"
            };

            var result = _sut.PostCompany(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Add(It.IsAny<Company>()), Times.Once);
        }

        [Test]
        public void UpdateCompanyReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new CompanyModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateCompany(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()), Times.Never);
        }

        [Test]
        public void UpdateCompanyReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new CompanyModel()
            {
                Id = 1
            };

            var result = _sut.UpdateCompany(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()), Times.Never);
        }

        [Test]
        public void UpdateCompanyReturnsNotFoundWhenCompanyIsNotFound()
        {
            var invalidModel = new CompanyModel()
            {
                Id = 1
            };

            _companyRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()))
                .Returns(false);

            var result = _sut.UpdateCompany(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()), Times.Once);
        }

        [Test]
        public void UpdateCompanyReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new CompanyModel()
            {
                Id = 1,
                Name = ""
            };

            _companyRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()))
                .Returns(true);

            var result = _sut.UpdateCompany(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Company>()), Times.Once);
        }

        [Test]
        public void DeleteCompanyReturnsNotFoundWhenCompanyIsNotFound()
        {
            Company company = null;

            _companyRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(company);

            var result = _sut.DeleteCompany(1) as NotFoundResult;

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

            var result = _sut.DeleteCompany(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _companyRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _companyRepositoryMock.Verify(m => m.Remove(It.IsAny<Company>()), Times.Once);
        }
    }
}
