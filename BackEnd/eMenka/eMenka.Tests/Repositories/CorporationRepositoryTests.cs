using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class CorporationRepositoryTests
    {
        private CorporationRepository _sut;

        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new CorporationRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        [Test]
        public void GetAllIncludesAllRelationsOfCorporation()
        {
            var company = new Company();

            var corporation = new Corporation()
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

            var corporation = new Corporation()
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

            var corporation = new Corporation()
            {
                Company = company
            };

            _sut.Add(corporation);

            var corporationFromDatabase = _sut.Find(c => c.Id == corporation.Id).FirstOrDefault();

            Assert.That(corporationFromDatabase.Company, Is.EqualTo(company));
        }
    }
}
