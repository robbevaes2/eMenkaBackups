using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class PersonRepositoryTests
    {
        private PersonRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new PersonRepository(EfenkaContextTestFactory.EfenkaContext);

            var person = new Person();

            _sut.Add(person);

            var personFromDatabase = _sut.GetById(person.Id);

            Assert.That(personFromDatabase, Is.EqualTo(person));
        }
    }
}