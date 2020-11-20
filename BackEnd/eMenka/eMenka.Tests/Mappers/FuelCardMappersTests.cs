using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
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
            int id = 1;
            DateTime endDate = DateTime.Now;
            DateTime startDate = DateTime.Now;
            DateTime blockingDate = DateTime.Now;
            string blockingReason = "reason";
            bool isBlocked = true;
            string pinCode = "1234";
            string number = "2345678";

            FuelCard fuelCard = new FuelCard()
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

            FuelCardReturnModel result = FuelCardMappers.MapFuelCardEntity(fuelCard);

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
            int id = 1;
            DateTime endDate = DateTime.Now;
            DateTime startDate = DateTime.Now;
            DateTime blockingDate = DateTime.Now;
            string blockingReason = "reason";
            bool isBlocked = true;
            string pinCode = "1234";
            string number = "2345678";
            int driverId = 1;

            FuelCardModel fuelCardModel = new FuelCardModel()
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

            FuelCard result = FuelCardMappers.MapFuelCardModel(fuelCardModel);

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
            int id = 1;
            DateTime endDate = DateTime.Now;
            DateTime startDate = DateTime.Now;

            Driver driver = new Driver()
            {
                Id = id,
                Person = null,
                EndDate = endDate,
                StartDate = startDate
            };

            DriverReturnModel result = FuelCardMappers.MapDriverEntity(driver);

            Assert.That(result.Person, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapDriverModelReturnsDriverWithCorrectProperties()
        {
            int id = 1;
            DateTime endDate = DateTime.Now;
            DateTime startDate = DateTime.Now;
            int personId = 1;

            DriverModel driverModel = new DriverModel()
            {
                Id = id,
                PersonId = personId,
                EndDate = endDate,
                StartDate = startDate
            };

            Driver result = FuelCardMappers.MapDriverModel(driverModel);

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
            int id = 1;
            string title = "mr";
            DateTime birthdate = DateTime.Now;
            DateTime startdateDriversLicense = DateTime.Now;
            byte[] picture = new byte[2];
            string lastname = "last";
            Language language = Language.Dutch;
            string gender = "m";
            string firstname = "first";
            DateTime enddateDriversLicense = DateTime.Now;
            string driversLicenseNumber = "23456789";
            string driversLicenseType = "A";

            Person person = new Person()
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

            PersonReturnModel result = FuelCardMappers.MapPersonEntity(person);

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
            int id = 1;
            string title = "mr";
            DateTime birthdate = DateTime.Now;
            DateTime startdateDriversLicense = DateTime.Now;
            byte[] picture = new byte[2];
            string lastname = "last";
            Language language = Language.Dutch;
            string gender = "m";
            string firstname = "first";
            DateTime enddateDriversLicense = DateTime.Now;
            string driversLicenseNumber = "23456789";
            string driversLicenseType = "A";

            PersonModel personModel = new PersonModel()
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

            Person result = FuelCardMappers.MapPersonModel(personModel);

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
