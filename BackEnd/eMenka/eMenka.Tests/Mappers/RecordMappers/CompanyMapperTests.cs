using eMenka.API.Mappers.RecordMappers;
using eMenka.API.Models.RecordModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.RecordMappers
{
    [TestFixture]
    public class CompanyMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new CompanyMapper();
        }

        private CompanyMapper _sut;

        [Test]
        public void MapCompanyEntityReturnsNullWhenCompanyIsNull()
        {
            Company company = null;

            var result = _sut.MapEntityToReturnModel(company);

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

            var result = _sut.MapEntityToReturnModel(company);

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

            var result = _sut.MapModelToEntity(companyModel);

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