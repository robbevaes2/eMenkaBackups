using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class ExteriorColorRepositoryTests
    {
        private ExteriorColorRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new ExteriorColorRepository(EfenkaContextTestFactory.EfenkaContext);

            var exteriorColor = new ExteriorColor
            {
                BrandId = 1
            };

            _sut.Add(exteriorColor);

            var exteriorColorFromDatabase = _sut.GetById(exteriorColor.Id);

            Assert.That(exteriorColorFromDatabase, Is.EqualTo(exteriorColor));
        }
    }
}