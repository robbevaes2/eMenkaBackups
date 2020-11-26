using eMenka.API.Mappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using NUnit.Framework;
using System;
using eMenka.API.Mappers.StaticMappers;

namespace eMenka.Tests.Mappers
{
    [TestFixture]
    public class FuelCardMappersTests
    {
        /*
        [Test]
        public void MapFuelCardEntityReturnNullWhenModelIsNull()
        {
            FuelCard fuelCard = null;

            var result = FuelCardMapper.MapFuelCardEntity(fuelCard);

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

            var result = FuelCardMapper.MapFuelCardEntity(fuelCard);

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

            var result = FuelCardMapper.MapFuelCardModel(fuelCardModel);

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

            var result = FuelCardMapper.MapDriverEntity(driver);

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

            var result = FuelCardMapper.MapDriverEntity(driver);

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

            var result = FuelCardMapper.MapDriverModel(driverModel);

            Assert.That(result.PersonId, Is.EqualTo(personId));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
                
        }*/
    }
}