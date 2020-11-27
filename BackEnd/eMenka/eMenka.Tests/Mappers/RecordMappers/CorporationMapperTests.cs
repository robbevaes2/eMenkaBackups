﻿using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers.FuelCardMappers;
using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Models.RecordModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.RecordMappers
{
    [TestFixture]
    public class CorporationMapperTests
    {
        private CorporationMapper _sut;

        [SetUp]
        public void Init()
        {
            _sut = new CorporationMapper();
        }

        [Test]
        public void MapCorporationEntityReturnsNullWhenCorporationIsNull()
        {
            Corporation corporation = null;

            var result = _sut.MapEntityToReturnModel(corporation);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapCorporationEntityReturnsReturnModelWithCorrectProperties()
        {
            var abbreviation = "abb";
            var endDate = DateTime.Now;
            var id = 1;
            var name = "name";
            var startDate = DateTime.Now;

            var corporation = new Corporation
            {
                Abbreviation = abbreviation,
                EndDate = endDate,
                Company = null,
                Id = id,
                Name = name,
                StartDate = startDate
            };

            var result = _sut.MapEntityToReturnModel(corporation);

            Assert.That(result.Company, Is.Null);
            Assert.That(result.Abbreviation, Is.EqualTo(abbreviation));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapCorporationModelReturnsCorporationWithCorrectProperties()
        {
            var abbreviation = "abb";
            var endDate = DateTime.Now;
            var id = 1;
            var name = "name";
            var startDate = DateTime.Now;
            var companyId = 1;

            var corporationModel = new CorporationModel
            {
                Abbreviation = abbreviation,
                CompanyId = companyId,
                EndDate = endDate,
                Id = id,
                Name = name,
                StartDate = startDate
            };

            var result = _sut.MapModelToEntity(corporationModel);

            Assert.That(result.CompanyId, Is.EqualTo(companyId));
            Assert.That(result.Abbreviation, Is.EqualTo(abbreviation));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }
    }
}
