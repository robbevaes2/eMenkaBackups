using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using eMenka.API.Controllers;
using eMenka.API.Models.SupplierModels;
using eMenka.API.Models.SupplierModels.ReturnModels;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class SupplierControllerTests
    {
        private Mock<ISupplierRepository> _supplierRepository;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Init()
        {
            _supplierRepository = new Mock<ISupplierRepository>();
            _mapperMock = new Mock<IMapper>();
        }

        [Test]
        public void ConstructorSetsCorrectPropertiesInBaseClass()
        {
            GenericController<Supplier, SupplierModel, SupplierReturnModel> supplierController =
                new SupplierController(_supplierRepository.Object, _mapperMock.Object);

            _supplierRepository.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(new Supplier());
            _mapperMock.Setup(m => m.Map<SupplierReturnModel>(It.IsAny<Supplier>()))
                .Returns(new SupplierReturnModel());
            var result = supplierController.GetEntityById(1) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((SupplierReturnModel)result.Value, Is.Not.Null);
        }
    }
}
