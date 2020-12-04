using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class SupplierRepositoryTests
    {
        private SupplierRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new SupplierRepository(EfenkaContextTestFactory.EfenkaContext);

            var supplier = new Supplier();

            _sut.Add(supplier);

            var supplierFromDatabase = _sut.GetById(supplier.Id);

            Assert.That(supplierFromDatabase, Is.EqualTo(supplier));
        }
    }
}
