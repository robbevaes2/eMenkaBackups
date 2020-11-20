using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using NUnit.Framework;

namespace eMenka.Tests.Mappers
{
    [TestFixture]
    public class RecordMappersTests
    {
        [Test]
        public void MapRecordEntityReturnNullWhenRecordIsNull()
        {
            Record record = null;

            var result = RecordMappers.MapRecordEntity(null);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapRecordEntityReturnsRecordWithCorrectProperties()
        {
            int id = 1;
            Term term = Term.Short;
            Usage usage = Usage.Definitive;
            DateTime endDate = DateTime.Now;
            DateTime startDate = DateTime.Now;

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

            RecordReturnModel result = RecordMappers.MapRecordEntity(record);

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
            Term term = Term.Short;
            Usage usage = Usage.Definitive;
            DateTime endDate = DateTime.Now;
            DateTime startDate = DateTime.Now;
            int corporationId = 1;
            int costAllocationid = 1;
            int id = 1;
            int fuelcardId = 1;

            var recordModel = new RecordModel()
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

            Record result = RecordMappers.MapRecordModel(recordModel);

            Assert.That(result.CorporationId, Is.EqualTo(corporationId));
            Assert.That(result.CostAllocationId, Is.EqualTo(costAllocationid));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.FuelCardId, Is.EqualTo(fuelcardId));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
            Assert.That(result.Term, Is.EqualTo(term));
            Assert.That(result.Usage, Is.EqualTo(usage));
        }

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
            string abbreviation = "abb";
            DateTime endDate = DateTime.Now;
            int id = 1;
            string name = "name";
            DateTime startDate = DateTime.Now;

            Corporation corporation = new Corporation
            {
                Abbreviation = abbreviation,
                EndDate = endDate,
                Company = null,
                Id = id,
                Name = name,
                StartDate = startDate
            };

            CorporationReturnModel result = RecordMappers.MapCorporationEntity(corporation);

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
            string abbreviation = "abb";
            DateTime endDate = DateTime.Now;
            int id = 1;
            string name = "name";
            DateTime startDate = DateTime.Now;
            int companyId = 1;

            var corporationModel = new CorporationModel
            {
                Abbreviation = abbreviation,
                CompanyId = companyId,
                EndDate = endDate,
                Id = id,
                Name = name,
                StartDate = startDate
            };

            Corporation result = RecordMappers.MapCorporationModel(corporationModel);

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
            string abbreviation = "abb";
            DateTime endDate = DateTime.Now;
            int id = 1;
            string name = "name";
            DateTime startDate = DateTime.Now;

            var costAllocation = new CostAllocation()
            {
                Abbreviation = abbreviation,
                EndDate = endDate,
                Id = id,
                Name = name,
                StartDate = startDate
            };

            CostAllocationReturnModel result = RecordMappers.MapCostAllocationEntity(costAllocation);

            Assert.That(result.Abbreviation, Is.EqualTo(abbreviation));
            Assert.That(result.EndDate, Is.EqualTo(endDate));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.StartDate, Is.EqualTo(startDate));
        }

        [Test]
        public void MapCostAllocationModelReturnsCostAllocationWithCorrectProperties()
        {
            string abbreviation = "abb";
            DateTime endDate = DateTime.Now;
            int id = 1;
            string name = "name";
            DateTime startDate = DateTime.Now;

            var costAllocationModel = new CostAllocationModel()
            {
                Abbreviation = abbreviation,
                EndDate = endDate,
                Id = id,
                Name = name,
                StartDate = startDate
            };

            CostAllocation result = RecordMappers.MapCostAllocationModel(costAllocationModel);

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
            string name = "name";
            string accountNumber = "number";
            string description = "descidksf";
            int id = 1;
            bool isActive = true;
            bool isInternal = true;
            string nonActiveRemark = "remark";
            string reference = "ref";
            string vat = "21";

            Company company = new Company
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

            CompanyReturnModel result = RecordMappers.MapCompanyEntity(company);

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
            string name = "name";
            string accountNumber = "number";
            string description = "descidksf";
            int id = 1;
            bool isActive = true;
            bool isInternal = true;
            string nonActiveRemark = "remark";
            string reference = "ref";
            string vat = "21";

            CompanyModel companyModel = new CompanyModel
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

            Company result = RecordMappers.MapCompanyModel(companyModel);

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
    }
}
