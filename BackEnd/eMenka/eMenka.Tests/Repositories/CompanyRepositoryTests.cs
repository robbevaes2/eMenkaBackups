using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class CompanyRepositoryTests
    {
        private CompanyRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new CompanyRepository(EfenkaContextTestFactory.EfenkaContext);

            var company = new Company();

            _sut.Add(company);

            var companyFromDatabase = _sut.GetById(company.Id);

            Assert.That(companyFromDatabase, Is.EqualTo(company));
        }
    }
}