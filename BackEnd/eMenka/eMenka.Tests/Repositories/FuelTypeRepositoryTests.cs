using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class FuelTypeRepositoryTests
    {
        private FuelTypeRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new FuelTypeRepository(EfenkaContextTestFactory.EfenkaContext);

            var fuelType = new FuelType();

            _sut.Add(fuelType);

            var fuelTypeFromDatabase = _sut.GetById(fuelType.Id);

            Assert.That(fuelTypeFromDatabase, Is.EqualTo(fuelType));
        }
    }
}