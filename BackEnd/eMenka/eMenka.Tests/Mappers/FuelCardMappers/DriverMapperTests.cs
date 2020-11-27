using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Models.FuelCardModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.FuelCardMappers
{
    [TestFixture]
    public class DriverMapperTests
    {
        private DriverMapper _sut;

        [SetUp]
        public void Init()
        {
            _sut = new DriverMapper();
        }

        [Test]
        public void MapDriverEntityReturnNullWhenModelIsNull()
        {
            Driver driver = null;

            var result = _sut.MapEntityToReturnModel(driver);

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

            var result = _sut.MapEntityToReturnModel(driver);

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

            var result = _sut.MapModelToEntity(driverModel);

            Assert.That(result.PersonId, Is.EqualTo(personId));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));

        }
    }
}
