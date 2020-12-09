using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers.SupplierMappers;
using eMenka.API.Models.SupplierModels;
using eMenka.Domain.Classes;
using eMenka.Domain.Enums;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.SupplierMappers
{
    [TestFixture]
    public class SupplierMapperTests
    {
        [SetUp]
        public void Init()
        {
            _sut = new SupplierMapper();
        }

        private SupplierMapper _sut;

        [Test]
        public void MapSupplierEntityReturnNullWhenModelIsNull()
        {
            Supplier supplier = null;

            var result = _sut.MapEntityToReturnModel(supplier);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapSupplierEntityReturnsReturnModelWithCorrectProperties()
        {
            var id = 1;
            bool active = true;
            bool internalOfProperty = true;
            string name = "name";
            SupplierType[] supplierTypes = new SupplierType[] {SupplierType.Garage, SupplierType.Bandencentrale};


            var supplier = new Supplier()
            {
                Id = id,
                Active = active,
                Internal = internalOfProperty,
                Name = name,
                Types = supplierTypes
            };

            var result = _sut.MapEntityToReturnModel(supplier);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Active, Is.EqualTo(active));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Internal, Is.EqualTo(internalOfProperty));
            Assert.That(result.Types, Is.EqualTo(supplierTypes));
        }

        [Test]
        public void MapSupplierModelReturnsDriverWithCorrectProperties()
        {
            var id = 1;
            bool active = true;
            bool internalOfProperty = true;
            string name = "name";
            SupplierType[] supplierTypes = new SupplierType[] { SupplierType.Garage, SupplierType.Bandencentrale };

            var supplierModel = new SupplierModel()
            {
                Id = id,
                Active = active,
                Internal = internalOfProperty,
                Name = name,
                Types = supplierTypes
            };

            var result = _sut.MapModelToEntity(supplierModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Active, Is.EqualTo(active));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Internal, Is.EqualTo(internalOfProperty));
            Assert.That(result.Types, Is.EqualTo(supplierTypes));
        }
    }
}
