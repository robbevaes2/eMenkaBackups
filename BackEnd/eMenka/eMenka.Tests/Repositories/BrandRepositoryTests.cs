using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class BrandRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new BrandRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private BrandRepository _sut;

        [Test]
        public void GetAllIncludesAllRelationsOfBrand()
        {
            var exteriorColors = new List<ExteriorColor>();
            var interiorColors = new List<InteriorColor>();

            var brand = new Brand
            {
                ExteriorColors = exteriorColors,
                InteriorColors = interiorColors
            };

            _sut.Add(brand);

            var brands = _sut.GetAll();

            Assert.That(brands, Is.Not.Null);

            var brandFromDatabase = brands.FirstOrDefault(b => b.Id == brand.Id);

            Assert.That(brandFromDatabase.ExteriorColors, Is.EqualTo(exteriorColors));
            Assert.That(brandFromDatabase.InteriorColors, Is.EqualTo(interiorColors));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfBrand()
        {
            var exteriorColors = new List<ExteriorColor>();
            var interiorColors = new List<InteriorColor>();

            var brand = new Brand
            {
                ExteriorColors = exteriorColors,
                InteriorColors = interiorColors
            };

            _sut.Add(brand);

            var brandFromDatabase = _sut.GetById(brand.Id);

            Assert.That(brandFromDatabase.ExteriorColors, Is.EqualTo(exteriorColors));
            Assert.That(brandFromDatabase.InteriorColors, Is.EqualTo(interiorColors));
        }

        [Test]
        public void FindIncludesAllRelationsOfBrand()
        {
            var exteriorColors = new List<ExteriorColor>();
            var interiorColors = new List<InteriorColor>();

            var brand = new Brand
            {
                ExteriorColors = exteriorColors,
                InteriorColors = interiorColors
            };

            _sut.Add(brand);

            var brandFromDatabase = _sut.Find(b => b.Id == brand.Id).FirstOrDefault();

            Assert.That(brandFromDatabase.ExteriorColors, Is.EqualTo(exteriorColors));
            Assert.That(brandFromDatabase.InteriorColors, Is.EqualTo(interiorColors));
        }
    }
}