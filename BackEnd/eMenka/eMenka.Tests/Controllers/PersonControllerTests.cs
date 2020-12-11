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
    public class PersonControllerTests
    {
        private PersonController _sut;
        private Mock<IPersonRepository> _personRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _personRepositoryMock = new Mock<IPersonRepository>();
            _mapperMock = new Mock<IMapper>();
            _sut = new PersonController(_personRepositoryMock.Object, _mapperMock.Object);
        }


        [Test]
        public void GetAllPersonsReturnsOkAndListOfAllPersonsWhenEverythingIsCorrect()
        {
            var persons = new List<Person>();

            _personRepositoryMock.Setup(m => m.GetAll())
                .Returns(persons);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<PersonReturnModel>;
            Assert.That(value, Is.Not.Null);
            _personRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetPersonByIdReturnsNotFoundWhenPersonDoesNotExist()
        {
            Person person = null;

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetPersonByIdReturnsOkAndPersonWhenEverythingIsCorrect()
        {
            var person = new Person();

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);
            _mapperMock.Setup(m => m.Map<PersonReturnModel>(It.IsAny<Person>()))
                .Returns(new PersonReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as PersonReturnModel;
            Assert.That(value, Is.Not.Null);
            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostPersonReturnsBadRequestWhenPersonWithDriversLicenseAlreadyExists()
        {
            var invalidModel = new PersonModel
            {
                DriversLicenseNumber = "123"
            };

            var persons = new List<Person>
            {
                new Person()
            };

            _personRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()))
                .Returns(persons);

            var result = _sut.PostEntity(invalidModel) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.Add(It.IsAny<Person>()), Times.Never);
            _personRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()), Times.Once);
        }

        [Test]
        public void PostPersonReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new PersonModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.Add(It.IsAny<Person>()), Times.Never);
            _personRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()), Times.Once);
        }

        [Test]
        public void PostPersonReturnsOkWhenModelIsValid()
        {
            var validModel = new PersonModel();
            _mapperMock.Setup(m => m.Map<PersonReturnModel>(It.IsAny<Person>()))
                .Returns(new PersonReturnModel());
            _mapperMock.Setup(m => m.Map<Person>(It.IsAny<PersonModel>()))
                .Returns(new Person());
            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((PersonReturnModel)result.Value, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.Add(It.IsAny<Person>()), Times.Once);
            _personRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdatePersonReturnsBadRequestWhenPersonWithDriversLicenseAlreadyExistsAndIsntDriversLicenseFromUpdatingPerson()
        {
            var invalidModel = new PersonModel
            {
                DriversLicenseNumber = "123",
                Id = 1
            };

            var persons = new List<Person>
            {
                new Person
                {
                    Id = invalidModel.Id + 1
                }
            };

            _personRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()))
                .Returns(persons);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.Add(It.IsAny<Person>()), Times.Never);
            _personRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdatePersonReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new PersonModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Person>()), Times.Never);
            _personRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdatePersonReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new PersonModel
            {
                Id = 1
            };

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Person>()), Times.Never);
            _personRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdatePersonReturnsNotFoundWhenPersonIsNotFound()
        {
            var invalidModel = new PersonModel
            {
                Id = 1
            };

            _personRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Person>()))
                .Returns(false);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Person>()), Times.Once);
            _personRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdatePersonReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new PersonModel
            {
                Id = 1
            };

            _personRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Person>()))
                .Returns(true);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Person>()), Times.Once);
            _personRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Person, bool>>>()), Times.Once);
        }

        [Test]
        public void DeletePersonReturnsNotFoundWhenPersonIsNotFound()
        {
            Person person = null;

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _personRepositoryMock.Verify(m => m.Remove(It.IsAny<Person>()), Times.Never);
        }

        [Test]
        public void DeletePersonReturnsOkWhenEverythingIsCorrect()
        {
            var person = new Person();

            _personRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(person);

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _personRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _personRepositoryMock.Verify(m => m.Remove(It.IsAny<Person>()), Times.Once);
        }
    }
}