﻿using eMenka.API.Mappers;
using eMenka.API.Models.RecordModels;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using NUnit.Framework;
using System;

namespace eMenka.Tests.Mappers
{
    [TestFixture]
    public class RecordMappersTests
    {
        /*

        [Test]
        public void MapCorporationEntityReturnsNullWhenCorporationIsNull()
        {
            Corporation corporation = null;

            var result = RecordMappers.MapCorporationEntity(corporation);

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

            var result = RecordMappers.MapCorporationEntity(corporation);

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

            var result = RecordMappers.MapCorporationModel(corporationModel);

            Assert.That(result.CompanyId, Is.EqualTo(companyId));
            Assert.That(result.Abbreviation, Is.EqualTo(abbreviation));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapCostAllocationEntityReturnsNullWhenCostAllocationIsNull()
        {
            CostAllocation costAllocation = null;

            var result = RecordMappers.MapCostAllocationEntity(costAllocation);

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

            var result = RecordMappers.MapCostAllocationEntity(costAllocation);

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

            var result = RecordMappers.MapCostAllocationModel(costAllocationModel);

            Assert.That(result.Abbreviation, Is.EqualTo(abbreviation));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapCompanyEntityReturnsNullWhenCompanyIsNull()
        {
            Company company = null;

            var result = RecordMappers.MapCompanyEntity(company);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapCompanyEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var accountNumber = "number";
            var description = "descidksf";
            var id = 1;
            var isActive = true;
            var isInternal = true;
            var nonActiveRemark = "remark";
            var reference = "ref";
            var vat = "21";

            var company = new Company
            {
                AccountNumber = accountNumber,
                Description = description,
                Id = id,
                IsActive = isActive,
                IsInternal = isInternal,
                Name = name,
                NonActiveRemark = nonActiveRemark,
                Reference = reference,
                VAT = vat
            };

            var result = RecordMappers.MapCompanyEntity(company);

            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.AccountNumber, Is.EqualTo(accountNumber));
            Assert.That(result.Description, Is.EqualTo(description));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.IsInternal, Is.EqualTo(isInternal));
            Assert.That(result.NonActiveRemark, Is.EqualTo(nonActiveRemark));
            Assert.That(result.Reference, Is.EqualTo(reference));
            Assert.That(result.VAT, Is.EqualTo(vat));
        }

        [Test]
        public void MapCompanyModelReturnsCompanyWithCorrectProperties()
        {
            var name = "name";
            var accountNumber = "number";
            var description = "descidksf";
            var id = 1;
            var isActive = true;
            var isInternal = true;
            var nonActiveRemark = "remark";
            var reference = "ref";
            var vat = "21";

            var companyModel = new CompanyModel
            {
                AccountNumber = accountNumber,
                Description = description,
                Id = id,
                IsActive = isActive,
                IsInternal = isInternal,
                Name = name,
                NonActiveRemark = nonActiveRemark,
                Reference = reference,
                VAT = vat
            };

            var result = RecordMappers.MapCompanyModel(companyModel);

            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.AccountNumber, Is.EqualTo(accountNumber));
            Assert.That(result.Description, Is.EqualTo(description));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.IsInternal, Is.EqualTo(isInternal));
            Assert.That(result.NonActiveRemark, Is.EqualTo(nonActiveRemark));
            Assert.That(result.Reference, Is.EqualTo(reference));
            Assert.That(result.VAT, Is.EqualTo(vat));
        }*/
    }
}