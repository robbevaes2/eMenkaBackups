using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class InteriorColorRepositoryTests
    {
        private InteriorColorRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new InteriorColorRepository(EfenkaContextTestFactory.EfenkaContext);

            var interiorColor = new InteriorColor
            {
                BrandId = 1
            };

            _sut.Add(interiorColor);

            var interiorColorFromDatabase = _sut.GetById(interiorColor.Id);

            Assert.That(interiorColorFromDatabase, Is.EqualTo(interiorColor));
        }
    }
}