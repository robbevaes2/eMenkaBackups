using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data;
using eMenka.Data.Repositories;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class BrandRepositoryTests 
    {
        private BrandRepository _sut;

        [OneTimeSetUp]
        public void Init()
        {
            if (EfenkaContextTestFactory.EfenkaContext == null)
            {
                EfenkaContextTestFactory.Create();
            }
            _sut = new BrandRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        [Test]
        public void UselessBrandTest()
        {
            Assert.That(true, Is.EqualTo(true));
        }

    }
}
