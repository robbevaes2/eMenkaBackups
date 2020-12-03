using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class FuelCardTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new FuelCard();
        }

        private FuelCard _sut;

        [Test]
        public void FuelCardCompanyIdPropertyGetsAndSetsCompanyId()
        {
            var companyId = 1;

            _sut.CompanyId = companyId;

            Assert.That(_sut.CompanyId, Is.EqualTo(companyId));
        }

        [Test]
        public void FuelCardCompanyPropertyGetsAndSetsCompany()
        {
            var company = new Company();

            _sut.Company = company;

            Assert.That(_sut.Company, Is.EqualTo(company));
        }

        [Test]
        public void FuelCardRecordIdPropertyGetsAndSetsRecordId()
        {
            var recordId = 1;

            _sut.RecordId = recordId;

            Assert.That(_sut.RecordId, Is.EqualTo(recordId));
        }

        [Test]
        public void FuelCardRecordPropertyGetsAndSetsRecord()
        {
            var record = new Record();

            _sut.Record = record;

            Assert.That(_sut.Record, Is.EqualTo(record));
        }
    }
}