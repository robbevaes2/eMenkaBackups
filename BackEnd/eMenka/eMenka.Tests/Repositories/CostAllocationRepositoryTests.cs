using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class CostAllocationRepositoryTests
    {
        private CostAllocationRepository _sut;

        [Test]
        public void ConstructorSetsCorrectEfenkaContext() //done by checking if getbyid works
        {
            EfenkaContextTestFactory.Create();

            _sut = new CostAllocationRepository(EfenkaContextTestFactory.EfenkaContext);

            var costAllocation = new CostAllocation();

            _sut.Add(costAllocation);

            var costAllocationFromDatabase = _sut.GetById(costAllocation.Id);

            Assert.That(costAllocationFromDatabase, Is.EqualTo(costAllocation));
        }
    }
}