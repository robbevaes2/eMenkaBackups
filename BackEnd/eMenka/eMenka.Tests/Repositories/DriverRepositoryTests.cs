using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;
using System.Linq;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class DriverRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new DriverRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private DriverRepository _sut;

        [Test]
        public void GetAllIncludesAllRelationsOfDriver()
        {
            var person = new Person();

            var driver = new Driver
            {
                Person = person
            };

            _sut.Add(driver);

            var drivers = _sut.GetAll();

            Assert.That(drivers, Is.Not.Null);

            var driverFromDatabase = drivers.FirstOrDefault(b => b.Id == driver.Id);

            Assert.That(driverFromDatabase.Person, Is.EqualTo(person));
        }

        [Test]
        public void GetAllAvailableDriverReturnsAllDriversWithoutAFuelCard()
        {
            var drivers = _sut.GetAllAvailableDrivers();

            foreach (var driver in drivers)
            {
                Assert.That(driver.FuelCardId, Is.Null);
            }
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfDriver()
        {
            var person = new Person();

            var driver = new Driver
            {
                Person = person
            };

            _sut.Add(driver);

            var driverFromDatabase = _sut.GetById(driver.Id);

            Assert.That(driverFromDatabase.Person, Is.EqualTo(person));
        }

        [Test]
        public void FindIncludesAllRelationsOfDriver()
        {
            var person = new Person();

            var driver = new Driver
            {
                Person = person
            };

            _sut.Add(driver);

            var driverFromDatabase = _sut.Find(d => d.Id == driver.Id).FirstOrDefault();

            Assert.That(driverFromDatabase.Person, Is.EqualTo(person));
        }
    }
}