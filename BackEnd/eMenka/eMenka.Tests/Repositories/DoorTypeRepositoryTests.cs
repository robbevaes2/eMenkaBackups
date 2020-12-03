using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class DoorTypeRepositoryTests
    {
        private DoorTypeRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new DoorTypeRepository(EfenkaContextTestFactory.EfenkaContext);

            var doorType = new DoorType();

            _sut.Add(doorType);

            var doorTypeFromDatabase = _sut.GetById(doorType.Id);

            Assert.That(doorTypeFromDatabase, Is.EqualTo(doorType));
        }
    }
}