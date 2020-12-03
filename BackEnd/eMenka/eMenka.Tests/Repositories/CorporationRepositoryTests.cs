using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;
using System.Linq;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class CorporationRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new CorporationRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private CorporationRepository _sut;

        [Test]
        public void GetAllIncludesAllRelationsOfCorporation()
        {
            var company = new Company();

            var corporation = new Corporation
            {
                Company = company
            };

            _sut.Add(corporation);

            var corporations = _sut.GetAll();

            Assert.That(corporations, Is.Not.Null);

            var corporationFromDatabase = corporations.FirstOrDefault(b => b.Id == corporation.Id);

            Assert.That(corporationFromDatabase.Company, Is.EqualTo(company));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfCorporation()
        {
            var company = new Company();

            var corporation = new Corporation
            {
                Company = company
            };

            _sut.Add(corporation);

            var corporationFromDatabase = _sut.GetById(corporation.Id);

            Assert.That(corporationFromDatabase.Company, Is.EqualTo(company));
        }

        [Test]
        public void FindIncludesAllRelationsOfCorporation()
        {
            var company = new Company();

            var corporation = new Corporation
            {
                Company = company
            };

            _sut.Add(corporation);

            var corporationFromDatabase = _sut.Find(c => c.Id == corporation.Id).FirstOrDefault();

            Assert.That(corporationFromDatabase.Company, Is.EqualTo(company));
        }
    }
}