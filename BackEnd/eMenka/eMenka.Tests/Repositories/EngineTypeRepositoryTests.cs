using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;
using System.Linq;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class EngineTypeRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new EngineTypeRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private EngineTypeRepository _sut;

        [Test]
        public void GetAllIncludesAllRelationsOfEngineType()
        {
            var brand = new Brand();

            var engineType = new EngineType
            {
                Brand = brand
            };

            _sut.Add(engineType);

            var engineTypes = _sut.GetAll();

            Assert.That(engineTypes, Is.Not.Null);

            var engineTypeFromDatabase = engineTypes.FirstOrDefault(b => b.Id == engineType.Id);

            Assert.That(engineTypeFromDatabase.Brand, Is.EqualTo(brand));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfEngineType()
        {
            var brand = new Brand();

            var engineType = new EngineType
            {
                Brand = brand
            };

            _sut.Add(engineType);

            var engineTypeFromDatabase = _sut.GetById(engineType.Id);

            Assert.That(engineTypeFromDatabase.Brand, Is.EqualTo(brand));
        }

        [Test]
        public void FindIncludesAllRelationsOfEngineType()
        {
            var brand = new Brand();

            var engineType = new EngineType
            {
                Brand = brand
            };

            _sut.Add(engineType);

            var engineTypeFromDatabase = _sut.Find(et => et.Id == engineType.Id).FirstOrDefault();

            Assert.That(engineTypeFromDatabase.Brand, Is.EqualTo(brand));
        }
    }
}