using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using NUnit.Framework;
using System;

namespace eMenka.Tests.Mappers.FuelCardMappers
{
    [TestFixture]
    public class PersonMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new PersonMapper();
        }

        private PersonMapper _sut;

        [Test]
        public void MapPersonEntityReturnNullWhenModelIsNull()
        {
            Person person = null;

            var result = _sut.MapEntityToReturnModel(person);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapPersonEntityReturnsReturnModelWithCorrectProperties()
        {
            var id = 1;
            var title = "mr";
            var birthdate = DateTime.Now;
            var startdateDriversLicense = DateTime.Now;
            var picture = new byte[2];
            var lastname = "last";
            var language = Language.Dutch;
            var gender = "m";
            var firstname = "first";
            var enddateDriversLicense = DateTime.Now;
            var driversLicenseNumber = "23456789";
            var driversLicenseType = "A";

            var person = new Person
            {
                Id = id,
                BirthDate = birthdate,
                Title = title,
                StartDateDriversLicense = startdateDriversLicense,
                Picture = picture,
                Lastname = lastname,
                Language = language,
                Gender = gender,
                EndDateDriversLicense = enddateDriversLicense,
                Firstname = firstname,
                DriversLicenseNumber = driversLicenseNumber,
                DriversLicenseType = driversLicenseType
            };

            var result = _sut.MapEntityToReturnModel(person);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.BirthDate, Is.EqualTo(birthdate));
            Assert.That(result.Title, Is.EqualTo(title));
            Assert.That(result.StartDateDriversLicense, Is.EqualTo(startdateDriversLicense));
            Assert.That(result.Picture, Is.EqualTo(picture));
            Assert.That(result.Language, Is.EqualTo(language));
            Assert.That(result.Lastname, Is.EqualTo(lastname));
            Assert.That(result.Gender, Is.EqualTo(gender));
            Assert.That(result.EndDateDriversLicense, Is.EqualTo(enddateDriversLicense));
            Assert.That(result.Firstname, Is.EqualTo(firstname));
            Assert.That(result.DriversLicenseNumber, Is.EqualTo(driversLicenseNumber));
            Assert.That(result.DriversLicenseType, Is.EqualTo(driversLicenseType));
        }

        [Test]
        public void MapPersonModelReturnsPersonWithCorrectProperties()
        {
            var id = 1;
            var title = "mr";
            var birthdate = DateTime.Now;
            var startdateDriversLicense = DateTime.Now;
            var picture = new byte[2];
            var lastname = "last";
            var language = Language.Dutch;
            var gender = "m";
            var firstname = "first";
            var enddateDriversLicense = DateTime.Now;
            var driversLicenseNumber = "23456789";
            var driversLicenseType = "A";

            var personModel = new PersonModel
            {
                Id = id,
                BirthDate = birthdate,
                Title = title,
                StartDateDriversLicense = startdateDriversLicense,
                Picture = picture,
                Lastname = lastname,
                Language = language,
                Gender = gender,
                EndDateDriversLicense = enddateDriversLicense,
                Firstname = firstname,
                DriversLicenseNumber = driversLicenseNumber,
                DriversLicenseType = driversLicenseType
            };

            var result = _sut.MapModelToEntity(personModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.BirthDate, Is.EqualTo(birthdate));
            Assert.That(result.Title, Is.EqualTo(title));
            Assert.That(result.StartDateDriversLicense, Is.EqualTo(startdateDriversLicense));
            Assert.That(result.Picture, Is.EqualTo(picture));
            Assert.That(result.Language, Is.EqualTo(language));
            Assert.That(result.Lastname, Is.EqualTo(lastname));
            Assert.That(result.Gender, Is.EqualTo(gender));
            Assert.That(result.EndDateDriversLicense, Is.EqualTo(enddateDriversLicense));
            Assert.That(result.Firstname, Is.EqualTo(firstname));
            Assert.That(result.DriversLicenseNumber, Is.EqualTo(driversLicenseNumber));
            Assert.That(result.DriversLicenseType, Is.EqualTo(driversLicenseType));
        }
    }
}