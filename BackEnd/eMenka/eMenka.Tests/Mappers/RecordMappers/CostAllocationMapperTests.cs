using System;
using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Models.RecordModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.RecordMappers
{
    [TestFixture]
    public class CostAllocationMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new CostAllocationMapper();
        }

        private CostAllocationMapper _sut;

        [Test]
        public void MapCostAllocationEntityReturnsNullWhenCostAllocationIsNull()
        {
            CostAllocation costAllocation = null;

            var result = _sut.MapEntityToReturnModel(costAllocation);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapCostAllocationEntityReturnsReturnModelWithCorrectProperties()
        {
            var abbreviation = "abb";
            var endDate = DateTime.Now;
            var id = 1;
            var name = "name";
            var startDate = DateTime.Now;

            var costAllocation = new CostAllocation
            {
                Abbreviation = abbreviation,
                EndDate = endDate,
                Id = id,
                Name = name,
                StartDate = startDate
            };

            var result = _sut.MapEntityToReturnModel(costAllocation);

            Assert.That(result.Abbreviation, Is.EqualTo(abbreviation));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapCostAllocationModelReturnsCostAllocationWithCorrectProperties()
        {
            var abbreviation = "abb";
            var endDate = DateTime.Now;
            var id = 1;
            var name = "name";
            var startDate = DateTime.Now;

            var costAllocationModel = new CostAllocationModel
            {
                Abbreviation = abbreviation,
                EndDate = endDate,
                Id = id,
                Name = name,
                StartDate = startDate
            };

            var result = _sut.MapModelToEntity(costAllocationModel);

            Assert.That(result.Abbreviation, Is.EqualTo(abbreviation));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }
    }
}