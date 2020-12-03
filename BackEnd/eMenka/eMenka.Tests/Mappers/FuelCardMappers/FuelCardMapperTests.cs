using System;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.FuelCardMappers
{
    [TestFixture]
    public class FuelCardMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new FuelCardMapper();
        }

        private FuelCardMapper _sut;

        [Test]
        public void MapFuelCardEntityReturnNullWhenModelIsNull()
        {
            FuelCard fuelCard = null;

            var result = _sut.MapEntityToReturnModel(fuelCard);

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
                Number = number,
                Vehicle = new Vehicle()
            };

            var result = _sut.MapEntityToReturnModel(fuelCard);

            Assert.That(result.Driver, Is.Null);
            Assert.That(result.Vehicle, Is.Not.Null);
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
        public void MapFuelCardModelReturnsCategoryWithCorrectProperties()
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
            var vehicleId = 1;

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
                Number = number,
                VehicleId = vehicleId
            };

            var result = _sut.MapModelToEntity(fuelCardModel);

            Assert.That(result.DriverId, Is.EqualTo(driverId));
            Assert.That(result.VehicleId, Is.EqualTo(vehicleId));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
            Assert.That(result.BlockingDate, Is.EqualTo(blockingDate));
            Assert.That(result.BlockingReason, Is.EqualTo(blockingReason));
            Assert.That(result.IsBlocked, Is.EqualTo(isBlocked));
            Assert.That(result.PinCode, Is.EqualTo(pinCode));
            Assert.That(result.Number, Is.EqualTo(number));
        }
    }
}