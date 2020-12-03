using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;
using System.Linq;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class ModelRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new ModelRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private ModelRepository _sut;

        [Test]
        public void GetAllIncludesAllRelationsOfModel()
        {
            var brand = new Brand();

            var model = new Model
            {
                Brand = brand
            };

            _sut.Add(model);

            var models = _sut.GetAll();

            Assert.That(models, Is.Not.Null);

            var modelFromDatabase = models.FirstOrDefault(m => m.Id == model.Id);

            Assert.That(modelFromDatabase.Brand, Is.EqualTo(brand));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfModel()
        {
            var brand = new Brand();

            var model = new Model
            {
                Brand = brand
            };

            _sut.Add(model);

            var modelFromDatabase = _sut.GetById(model.Id);

            Assert.That(modelFromDatabase.Brand, Is.EqualTo(brand));
        }

        [Test]
        public void FindIncludesAllRelationsOfModel()
        {
            var brand = new Brand();

            var model = new Model
            {
                Brand = brand
            };

            _sut.Add(model);

            var modelFromDatabase = _sut.Find(m => m.Id == model.Id).FirstOrDefault();

            Assert.That(modelFromDatabase.Brand, Is.EqualTo(brand));
        }
    }
}