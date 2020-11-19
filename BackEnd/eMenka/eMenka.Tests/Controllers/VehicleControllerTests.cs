﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using eMenka.API.Controllers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using VehicleReturnModel = eMenka.API.Models.VehicleModels.ReturnModels.VehicleReturnModel;

namespace eMenka.Tests.Controllers
{
    [TestFixture]
    public class VehicleControllerTests
    {
        private VehicleController _sut;
        private Mock<IVehicleRepository> _vehicleRepositoryMock;
        private Mock<IBrandRepository> _brandRepositoryMock;
        private Mock<IModelRepository> _modelRepositoryMock;
        private Mock<IFuelTypeRepository> _fuelTypeRepositoryMock;
        private Mock<IEngineTypeRepository> _engineTypeRepositoryMock;
        private Mock<IDoorTypeRepository> _doorTypeRepositoryMock;
        private Mock<ICategoryRepository> _categoryRepositoryMock;

        [SetUp]
        public void Init()
        {
            _vehicleRepositoryMock = new Mock<IVehicleRepository>();
            _brandRepositoryMock = new Mock<IBrandRepository>();
            _engineTypeRepositoryMock = new Mock<IEngineTypeRepository>();
            _modelRepositoryMock = new Mock<IModelRepository>();
            _fuelTypeRepositoryMock = new Mock<IFuelTypeRepository>();
            _doorTypeRepositoryMock = new Mock<IDoorTypeRepository>();
            _categoryRepositoryMock = new Mock<ICategoryRepository>();

            _sut = new VehicleController(_vehicleRepositoryMock.Object, _brandRepositoryMock.Object, _modelRepositoryMock.Object, _fuelTypeRepositoryMock.Object, _engineTypeRepositoryMock.Object, _doorTypeRepositoryMock.Object, _categoryRepositoryMock.Object);
        }

        [Test]
        public void GetAllVehiclesReturnsOkAndListOfAllVehiclesWhenEverythingIsCorrect()
        {
            var vehicles = new List<Vehicle>();

            _vehicleRepositoryMock.Setup(m => m.GetAll())
                .Returns(vehicles);

            var result = _sut.GetAllVehicles() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);
            _vehicleRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetVehicleByIdReturnsNotFoundWhenVehicleDoesNotExist()
        {
            Vehicle vehicle = null;

            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.GetVehicleById(0) as NotFoundResult;

            Assert.That(result, Is.Not.Null);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetVehcileByIdReturnsOkAndVehicleWhenEverythingIsCorrect()
        {
            var vehicle = new Vehicle
            {
                Brand = new Brand(),
                FuelCard = new FuelCard(),
                DoorType = new DoorType(),
                FuelType = new FuelType(),
                Model = new Model
                {
                    Brand = new Brand()
                },
                EngineType = new EngineType()
                {
                    Brand = new Brand()
                }
            };

            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.GetVehicleById(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as VehicleReturnModel;
            Assert.That(value, Is.Not.Null);
            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void GetVehiclesByBrandIdReturnsNotFoundWhenBrandDoesNotExist()
        {
            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.GetVehicleByBrandId(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void GetVehiclesByBrandIdReturnsOkAndVehicleWhenEverythingIsCorrect()
        {
            var brand = new Brand();
            var vehicles = new List<Vehicle>();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _vehicleRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .Returns(vehicles);

            var result = _sut.GetVehicleByBrandId(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void GetVehiclesByBrandNameReturnsOkAndVehicleWhenEverythingIsCorrect()
        {
            var vehicles = new List<Vehicle>();

            _vehicleRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .Returns(vehicles);

            var result = _sut.GetVehiclesByBrandName("name") as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void GetVehiclesByModelIdReturnsNotFoundWhenModelDoesNotExist()
        {
            Model model = null;

            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.GetVehicleByModelId(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void GetVehiclesByModelIdReturnsOkAndModelWhenEverythingIsCorrect()
        {
            var model = new Model();
            var vehicles = new List<Vehicle>();

            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _vehicleRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .Returns(vehicles);

            var result = _sut.GetVehicleByModelId(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);

            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void GetVehiclesByStatusReturnsOkAndVehicleWhenEverythingIsCorrect()
        {
            var vehicles = new List<Vehicle>();

            _vehicleRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .Returns(vehicles);

            var result = _sut.GetVehicleByStatus(true) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        //todo add tests for fuelcard

        [Test]
        public void PostVehicleReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new VehicleModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostVehicle(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenBrandIsNotFound()
        {
            var invalidModel = new VehicleModel()
            {
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostVehicle(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenModelIsNotFound()
        {
            var invalidModel = new VehicleModel()
            {
                BrandId = 1,
                ModelId = 1
            };

            var brand = new Brand();
            Model model = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.PostVehicle(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenFuelTypeIsNotFound()
        {
            var invalidModel = new VehicleModel()
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);

            var result = _sut.PostVehicle(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenMotorTypeIsNotFound()
        {
            var invalidModel = new VehicleModel()
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);

            var result = _sut.PostVehicle(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }
        [Test]
        public void PostVehicleReturnsNotFoundWhenDoorTypeIsNotFound()
        {
            var invalidModel = new VehicleModel()
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = new EngineType()
            {
                Brand = new Brand()
            };
            DoorType doorType = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);
            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);

            var result = _sut.PostVehicle(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenCategoryIsNotFound()
        {
            var invalidModel = new VehicleModel()
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                CategoryId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = new EngineType()
            {
                Brand = new Brand()
            };
            DoorType doorType = new DoorType();
            Category category = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);
            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);
            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);

            var result = _sut.PostVehicle(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostVehicleReturnsOkWhenModelIsValid()
        {
            var validModel = new VehicleModel()
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1,
                CategoryId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = new EngineType()
            {
                Brand = new Brand()
            };
            DoorType doorType = new DoorType();
            Category category = new Category();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);
            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);
            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);

            var result = _sut.PostVehicle(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }
        
        [Test]
        public void UpdateVehcileReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new VehicleModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateVehicle(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new VehicleModel()
            {
                Id = 1
            };

            var result = _sut.UpdateVehicle(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new VehicleModel()
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateVehicle(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }
        [Test]
        public void UpdateVehicleReturnsNotFoundWhenModelIsNotFound()
        {
            var validModel = new VehicleModel()
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1
            };

            Brand brand = new Brand();
            Model model = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.UpdateVehicle(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }
        [Test]
        public void UpdateVehicleReturnsNotFoundWhenFuelTypeIsNotFound()
        {
            var validModel = new VehicleModel()
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1
            };

            Brand brand = new Brand();
            Model model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);

            var result = _sut.UpdateVehicle(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }
        [Test]
        public void UpdateVehicleReturnsNotFoundWhenMotorTypeIsNotFound()
        {
            var validModel = new VehicleModel()
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1
            };

            Brand brand = new Brand();
            Model model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);

            var result = _sut.UpdateVehicle(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }
        [Test]
        public void UpdateVehicleReturnsNotFoundWhenDoorTypeIsNotFound()
        {
            var validModel = new VehicleModel()
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1
            };

            Brand brand = new Brand();
            Model model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = new EngineType()
            {
                Brand = new Brand()
            };
            DoorType doorType = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);
            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);

            var result = _sut.UpdateVehicle(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenCategoryIsNotFound()
        {
            var validModel = new VehicleModel()
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1,
                CategoryId = 1
            };

            Brand brand = new Brand();
            Model model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = new EngineType()
            {
                Brand = new Brand()
            };
            DoorType doorType = new DoorType();
            Category category = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);
            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);
            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);

            var result = _sut.UpdateVehicle(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdatevehicleReturnsNotFoundWhenVehicleIsNotFound()
        {
            var validModel = new VehicleModel()
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1,
                CategoryId = 1
            };

            Brand brand = new Brand();
            Model model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = new EngineType()
            {
                Brand = new Brand()
            };
            DoorType doorType = new DoorType();
            Category category = new Category();

            _vehicleRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()))
                .Returns(false);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);
            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);
            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);

            var result = _sut.UpdateVehicle(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateVehicleReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new VehicleModel()
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalePk = 1,
                Power = 1,
                Volume = 1,
                CategoryId = 1
            };

            Brand brand = new Brand();
            Model model = new Model
            {
                Brand = new Brand()
            };
            FuelType fuelType = new FuelType();
            EngineType engineType = new EngineType()
            {
                Brand = new Brand()
            };
            DoorType doorType = new DoorType();
            Category category = new Category();

            _vehicleRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()))
                .Returns(true);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);
            _doorTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(doorType);
            _categoryRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(category);

            var result = _sut.UpdateVehicle(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void DeleteVehicleReturnsNotFoundWhenVehicleIsNotFound()
        {
            Vehicle vehicle = null;

            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.DeleteVehicle(1) as NotFoundResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Remove(It.IsAny<Vehicle>()), Times.Never);
        }

        [Test]
        public void DeleteVehicleReturnsOkWhenEverythingIsCorrect()
        {
            var vehicle = new Vehicle();

            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.DeleteVehicle(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Remove(It.IsAny<Vehicle>()), Times.Once);
        }
    }
}
