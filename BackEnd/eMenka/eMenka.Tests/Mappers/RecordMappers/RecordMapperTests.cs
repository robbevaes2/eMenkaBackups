using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Models.RecordModels;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using NUnit.Framework;
using System;

namespace eMenka.Tests.Mappers.RecordMappers
{
    [TestFixture]
    public class RecordMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new RecordMapper();
        }

        private RecordMapper _sut;

        [Test]
        public void MapRecordEntityReturnNullWhenRecordIsNull()
        {
            Record record = null;

            var result = _sut.MapEntityToReturnModel(record);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapRecordEntityReturnsRecordWithCorrectProperties()
        {
            var id = 1;
            var term = Term.Short;
            var usage = Usage.Definitive;
            var endDate = DateTime.Now;
            var startDate = DateTime.Now;

            var record = new Record
            {
                Corporation = null,
                FuelCard = null,
                Term = term,
                Id = id,
                Usage = usage,
                EndDate = endDate,
                StartDate = startDate,
                CostAllocation = null
            };

            var result = _sut.MapEntityToReturnModel(record);

            Assert.That(result.Corporation, Is.Null);
            Assert.That(result.FuelCard, Is.Null);
            Assert.That(result.CostAllocation, Is.Null);
            Assert.That(result.Term, Is.EqualTo(term));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Usage, Is.EqualTo(usage));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapRecordModelReturnsRecordWithCorrectProperties()
        {
            var term = Term.Short;
            var usage = Usage.Definitive;
            var endDate = DateTime.Now;
            var startDate = DateTime.Now;
            var corporationId = 1;
            var costAllocationid = 1;
            var id = 1;
            var fuelcardId = 1;

            var recordModel = new RecordModel
            {
                CorporationId = corporationId,
                CostAllocationId = costAllocationid,
                EndDate = endDate,
                FuelCardId = fuelcardId,
                Id = id,
                StartDate = startDate,
                Term = term,
                Usage = usage
            };

            var result = _sut.MapModelToEntity(recordModel);

            Assert.That(result.CorporationId, Is.EqualTo(corporationId));
            Assert.That(result.CostAllocationId, Is.EqualTo(costAllocationid));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.FuelCardId, Is.EqualTo(fuelcardId));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
            Assert.That(result.Term, Is.EqualTo(term));
            Assert.That(result.Usage, Is.EqualTo(usage));
        }
    }
}