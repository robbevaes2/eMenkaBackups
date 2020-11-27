using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.Repositories;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class CategoryRepositoryTests
    {
        private CategoryRepository _sut;

        [OneTimeSetUp]
        public void Init()
        {
            if (EfenkaContextTestFactory.EfenkaContext == null)
            {
                EfenkaContextTestFactory.Create();
            }
            _sut = new CategoryRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        [Test]
        public void UselessBrandTest()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
