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
    public class DriverRepositoryTests
    {
        private DriverRepository _sut;

        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new DriverRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        [Test]
        public void GetAllIncludesAllRelationsOfDriver()
        {
            var person = new Person();

            var driver = new Driver()
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
        public void GetByIdIncludesAllRelationsOfDriver()
        {
            var person = new Person();

            var driver = new Driver()
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

            var driver = new Driver()
            {
                Person = person
            };

            _sut.Add(driver);

            var driverFromDatabase = _sut.Find(d => d.Id == driver.Id).FirstOrDefault();

            Assert.That(driverFromDatabase.Person, Is.EqualTo(person));
        }
    }
}
