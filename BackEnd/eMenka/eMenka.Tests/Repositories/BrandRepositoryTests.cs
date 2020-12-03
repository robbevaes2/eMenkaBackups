using System.Collections.Generic;
using System.Linq;
using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

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
            var enginetypes = new List<EngineType>();
            var models = new List<Model>();
            var exteriorColors = new List<ExteriorColor>();
            var interiorColors = new List<InteriorColor>();
            var series = new List<Series>();

            var brand = new Brand
            {
                EngineTypes = enginetypes,
                Models = models,
                ExteriorColors = exteriorColors,
                InteriorColors = interiorColors,
                Series = series
            };

            _sut.Add(brand);

            var brands = _sut.GetAll();

            Assert.That(brands, Is.Not.Null);

            var brandFromDatabase = brands.FirstOrDefault(b => b.Id == brand.Id);

            Assert.That(brandFromDatabase.EngineTypes, Is.EqualTo(enginetypes));
            Assert.That(brandFromDatabase.Models, Is.EqualTo(models));
            Assert.That(brandFromDatabase.ExteriorColors, Is.EqualTo(exteriorColors));
            Assert.That(brandFromDatabase.InteriorColors, Is.EqualTo(interiorColors));
            Assert.That(brandFromDatabase.Series, Is.EqualTo(series));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfBrand()
        {
            var enginetypes = new List<EngineType>();
            var models = new List<Model>();
            var exteriorColors = new List<ExteriorColor>();
            var interiorColors = new List<InteriorColor>();
            var series = new List<Series>();

            var brand = new Brand
            {
                EngineTypes = enginetypes,
                Models = models,
                ExteriorColors = exteriorColors,
                InteriorColors = interiorColors,
                Series = series
            };

            _sut.Add(brand);

            var brandFromDatabase = _sut.GetById(brand.Id);

            Assert.That(brandFromDatabase.EngineTypes, Is.EqualTo(enginetypes));
            Assert.That(brandFromDatabase.Models, Is.EqualTo(models));
            Assert.That(brandFromDatabase.ExteriorColors, Is.EqualTo(exteriorColors));
            Assert.That(brandFromDatabase.InteriorColors, Is.EqualTo(interiorColors));
            Assert.That(brandFromDatabase.Series, Is.EqualTo(series));
        }

        [Test]
        public void FindIncludesAllRelationsOfBrand()
        {
            var enginetypes = new List<EngineType>();
            var models = new List<Model>();
            var exteriorColors = new List<ExteriorColor>();
            var interiorColors = new List<InteriorColor>();
            var series = new List<Series>();

            var brand = new Brand
            {
                EngineTypes = enginetypes,
                Models = models,
                ExteriorColors = exteriorColors,
                InteriorColors = interiorColors,
                Series = series
            };

            _sut.Add(brand);

            var brandFromDatabase = _sut.Find(b => b.Id == brand.Id).FirstOrDefault();

            Assert.That(brandFromDatabase.EngineTypes, Is.EqualTo(enginetypes));
            Assert.That(brandFromDatabase.Models, Is.EqualTo(models));
            Assert.That(brandFromDatabase.ExteriorColors, Is.EqualTo(exteriorColors));
            Assert.That(brandFromDatabase.InteriorColors, Is.EqualTo(interiorColors));
            Assert.That(brandFromDatabase.Series, Is.EqualTo(series));
        }
    }
}