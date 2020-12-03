using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class CategoryRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new CategoryRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private CategoryRepository _sut;

        [Test]
        public void GetAllReturnsAnEnumarableOfCategories()
        {
            var categories = _sut.GetAll();

            Assert.That(categories, Is.Not.Null);
        }

        [Test]
        public void GetByIdReturnsCategoryWithCorrectIdAndAddAddsCorrectCategoryToDatabase()
        {
            var category = new Category
            {
                Name = "testname"
            };

            _sut.Add(category);

            var categoryFromDatabase = _sut.GetById(category.Id);

            Assert.That(categoryFromDatabase, Is.EqualTo(category));
        }

        [Test]
        public void FindReturnsCategoryWithAllCategoriesContainingProperty()
        {
            var category = new Category
            {
                Name = "testname"
            };

            _sut.Add(category);

            var categories = _sut.Find(c => c.Name == category.Name);

            foreach (var categoryFromDatabase in categories)
                Assert.That(categoryFromDatabase.Name, Is.EqualTo(category.Name));
        }

        [Test]
        public void RemoveRemovesCategoryFromDb()
        {
            var category = new Category
            {
                Name = "testname"
            };

            _sut.Add(category);

            var id = category.Id;

            _sut.Remove(category);

            var categoryFromDb = _sut.GetById(id);

            Assert.That(categoryFromDb, Is.Null);
        }

        [Test]
        public void UpdateReturnsFalseIfCategoryDoesNotExist()
        {
            var category = new Category
            {
                Name = "testname"
            };

            _sut.Add(category);

            var id = category.Id;

            _sut.Remove(category);

            var isUpdated = _sut.Update(id, category);

            Assert.That(isUpdated, Is.False);
        }

        [Test]
        public void UpdateReturnsTrueIfCategoryExistsAndUpdatesProperty()
        {
            var category = new Category
            {
                Name = "testname"
            };

            _sut.Add(category);

            var id = category.Id;

            category.Name = "testname2";

            var isUpdated = _sut.Update(id, category);
            var categoryFromDb = _sut.GetById(id);

            Assert.That(isUpdated, Is.True);
            Assert.That(categoryFromDb.Name, Is.EqualTo(category.Name));
        }
    }
}