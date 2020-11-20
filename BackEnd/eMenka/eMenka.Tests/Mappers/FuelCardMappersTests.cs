using System;
using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using NUnit.Framework;

namespace eMenka.Tests.Mappers
{
    [TestFixture]
    public class FuelCardMappersTests
    {
        [Test]
        public void MapFuelCardEntityReturnNullWhenModelIsNull()
        {
            FuelCard fuelCard = null;

            var result = FuelCardMappers.MapFuelCardEntity(fuelCard);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapFuelCardEntityReturnsReturnModelWithCorrectProperties()
        {
            var id = 1;
            var endDate = DateTime.Now;
            var startDate = DateTime.Now;
            var blockingDate = DateTime.Now;
            var blockingReason = "reason";
            var isBlocked = true;
            var pinCode = "1234";
            var number = "2345678";

            var fuelCard = new FuelCard
            {
                Id = id,
                Driver = null,
                EndDate = endDate,
                StartDate = startDate,
                BlockingDate = blockingDate,
                BlockingReason = blockingReason,
                IsBlocked = isBlocked,
                PinCode = pinCode,
                Number = number
            };

            var result = FuelCardMappers.MapFuelCardEntity(fuelCard);

            Assert.That(result.Driver, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
            Assert.That(result.BlockingDate, Is.EqualTo(blockingDate));
            Assert.That(result.BlockingReason, Is.EqualTo(blockingReason));
            Assert.That(result.IsBlocked, Is.EqualTo(isBlocked));
            Assert.That(result.PinCode, Is.EqualTo(pinCode));
            Assert.That(result.Number, Is.EqualTo(number));
        }

        [Test]
        public void MapCategoryModelReturnsCategoryWithCorrectProperties()
        {
            var id = 1;
            var endDate = DateTime.Now;
            var startDate = DateTime.Now;
            var blockingDate = DateTime.Now;
            var blockingReason = "reason";
            var isBlocked = true;
            var pinCode = "1234";
            var number = "2345678";
            var driverId = 1;

            var fuelCardModel = new FuelCardModel
            {
                Id = id,
                DriverId = driverId,
                EndDate = endDate,
                StartDate = startDate,
                BlockingDate = blockingDate,
                BlockingReason = blockingReason,
                IsBlocked = isBlocked,
                PinCode = pinCode,
                Number = number
            };

            var result = FuelCardMappers.MapFuelCardModel(fuelCardModel);

            Assert.That(result.DriverId, Is.EqualTo(driverId));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
            Assert.That(result.BlockingDate, Is.EqualTo(blockingDate));
            Assert.That(result.BlockingReason, Is.EqualTo(blockingReason));
            Assert.That(result.IsBlocked, Is.EqualTo(isBlocked));
            Assert.That(result.PinCode, Is.EqualTo(pinCode));
            Assert.That(result.Number, Is.EqualTo(number));
        }

        [Test]
        public void MapDriverEntityReturnNullWhenModelIsNull()
        {
            Driver driver = null;

            var result = FuelCardMappers.MapDriverEntity(driver);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapDriverEntityReturnsReturnModelWithCorrectProperties()
        {
            var id = 1;
            var endDate = DateTime.Now;
            var startDate = DateTime.Now;

            var driver = new Driver
            {
                Id = id,
                Person = null,
                EndDate = endDate,
                StartDate = startDate
            };

            var result = FuelCardMappers.MapDriverEntity(driver);

            Assert.That(result.Person, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapDriverModelReturnsDriverWithCorrectProperties()
        {
            var id = 1;
            var endDate = DateTime.Now;
            var startDate = DateTime.Now;
            var personId = 1;

            var driverModel = new DriverModel
            {
                Id = id,
                PersonId = personId,
                EndDate = endDate,
                StartDate = startDate
            };

            var result = FuelCardMappers.MapDriverModel(driverModel);

            Assert.That(result.PersonId, Is.EqualTo(personId));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapPersonEntityReturnNullWhenModelIsNull()
        {
            Person person = null;

            var result = FuelCardMappers.MapPersonEntity(person);

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

            var result = FuelCardMappers.MapPersonEntity(person);

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

            var result = FuelCardMappers.MapPersonModel(personModel);

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