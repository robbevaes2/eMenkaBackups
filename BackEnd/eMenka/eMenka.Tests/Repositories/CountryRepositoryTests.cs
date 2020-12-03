using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    public class CountryRepositoryTests
    {
        private CountryRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new CountryRepository(EfenkaContextTestFactory.EfenkaContext);

            var country = new Country();

            _sut.Add(country);

            var countryFromDatabase = _sut.GetById(country.Id);

            Assert.That(countryFromDatabase, Is.EqualTo(country));
        }
    }
}