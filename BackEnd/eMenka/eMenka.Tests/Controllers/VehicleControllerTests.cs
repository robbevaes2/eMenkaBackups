using eMenka.API.Controllers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Data.IRepositories;
using eMenka.Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;

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
        private Mock<IFuelCardRepository> _fuelcardRepositoryMock;
        private Mock<ISerieRepository> _serieRepositoryMock;
        private Mock<IRecordRepository> _recordRepositoryMock;
        private Mock<IMapper> _mapperMock;
        
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
            _fuelcardRepositoryMock = new Mock<IFuelCardRepository>();
            _serieRepositoryMock = new Mock<ISerieRepository>();
            _recordRepositoryMock = new Mock<IRecordRepository>();
            _mapperMock = new Mock<IMapper>();

        _sut = new VehicleController(_vehicleRepositoryMock.Object, _brandRepositoryMock.Object,
                _modelRepositoryMock.Object, _fuelTypeRepositoryMock.Object, _engineTypeRepositoryMock.Object,
                _doorTypeRepositoryMock.Object, _categoryRepositoryMock.Object, _serieRepositoryMock.Object,
                _fuelcardRepositoryMock.Object, _recordRepositoryMock.Object, _mapperMock.Object);
        }


        [Test]
        public void GetAllVehiclesReturnsOkAndListOfAllVehiclesWhenEverythingIsCorrect()
        {
            var vehicles = new List<Vehicle>();

            _vehicleRepositoryMock.Setup(m => m.GetAll())
                .Returns(vehicles);

            var result = _sut.GetAllEntities() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);
            _vehicleRepositoryMock.Verify(m => m.GetAll(), Times.Once);
        }

        [Test]
        public void GetAllAvailableVehiclesReturnsOkAndListOfAllAvailableVehiclesWhenEverythingIsCorrect()
        {
            var vehicles = new List<Vehicle>();

            _vehicleRepositoryMock.Setup(m => m.GetAllAvailableVehicles())
                .Returns(vehicles);

            var result = _sut.GetAllAvailableVehicles() as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);
            _vehicleRepositoryMock.Verify(m => m.GetAllAvailableVehicles(), Times.Once);
        }

        [Test]
        public void GetVehicleByIdReturnsNotFoundWhenVehicleDoesNotExist()
        {
            Vehicle vehicle = null;

            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.GetEntityById(0) as NotFoundObjectResult;

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
                EngineType = new EngineType
                {
                    Brand = new Brand()
                }
            };

            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);
            _mapperMock.Setup(m => m.Map<VehicleReturnModel>(It.IsAny<Vehicle>()))
                .Returns(new VehicleReturnModel());
            var result = _sut.GetEntityById(0) as OkObjectResult;

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
        public void GetAvailableVehiclesByBrandIdReturnsNotFoundWhenBrandDoesNotExist()
        {
            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.GetAvailableVehicleByBrandId(0) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetAllAvailableVehiclesByBrandId(It.IsAny<int>(), It.IsAny<List<int?>>()), Times.Never);
            _recordRepositoryMock.Verify(m => m.GetAll(), Times.Never);
        }

        [Test]
        public void GetAvailableVehiclesByBrandIdReturnsOkAndVehicleWhenEverythingIsCorrect()
        {
            var brand = new Brand();
            var vehicles = new List<Vehicle>();
            var records = new List<Record>
            {
                new Record
                {
                    FuelCardId = 1
                }
            };

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _vehicleRepositoryMock.Setup(m => m.GetAllAvailableVehiclesByBrandId(It.IsAny<int>(), It.IsAny<List<int?>>()))
                .Returns(vehicles);
            _recordRepositoryMock.Setup(m => m.GetAll())
                .Returns(records);

            var result = _sut.GetAvailableVehicleByBrandId(0) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);

            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.GetAllAvailableVehiclesByBrandId(It.IsAny<int>(), It.IsAny<List<int?>>()), Times.Once);
            _recordRepositoryMock.Verify(m => m.GetAll(), Times.Once);
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

        [Test]
        public void GetVehiclesByEndDateReturnsOkAndVehicleWhenEverythingIsCorrect()
        {
            var vehicles = new List<Vehicle>();

            _vehicleRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .Returns(vehicles);

            var result = _sut.GetVehiclesByEndDate(10) as OkObjectResult;

            Assert.That(result, Is.Not.Null);

            var value = result.Value as List<VehicleReturnModel>;
            Assert.That(value, Is.Not.Null);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void PostVehicleReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new VehicleModel
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            var series = new Series();

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostEntity(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenBrandIsNotFound()
        {
            var invalidModel = new VehicleModel
            {
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostEntity(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenModelIsNotFound()
        {
            var invalidModel = new VehicleModel
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

            var result = _sut.PostEntity(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenFuelTypeIsNotFound()
        {
            var invalidModel = new VehicleModel
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

            var result = _sut.PostEntity(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenMotorTypeIsNotFound()
        {
            var invalidModel = new VehicleModel
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
            var fuelType = new FuelType();
            EngineType engineType = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);

            var result = _sut.PostEntity(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenDoorTypeIsNotFound()
        {
            var invalidModel = new VehicleModel
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
            var fuelType = new FuelType();
            var engineType = new EngineType
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

            var result = _sut.PostEntity(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenCategoryIsNotFound()
        {
            var invalidModel = new VehicleModel
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
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
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

            var result = _sut.PostEntity(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenFuelcardIsNotFound()
        {
            var invalidModel = new VehicleModel
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                CategoryId = 1,
                FuelCardId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            FuelCard fuelCard = null;

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.PostEntity(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void PostVehicleReturnsNotFoundWhenSeriesIsNotFound()
        {
            var invalidModel = new VehicleModel
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            Series series = null;

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            var result = _sut.PostEntity(invalidModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void PostVehicleReturnsBadRequestIfFuelCardIsAlreadyInUse()
        {
            var validModel = new VehicleModel
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            var series = new Series();
            var vehicles = new List<Vehicle>
            {
                new Vehicle()
            };

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);
            _vehicleRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .Returns(vehicles);

            var result = _sut.PostEntity(validModel) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void PostVehicleReturnsOkWhenModelIsValid()
        {
            var validModel = new VehicleModel
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            var series = new Series();
            _mapperMock.Setup(m => m.Map<Vehicle>(It.IsAny<VehicleModel>()))
                .Returns(new Vehicle());
            _mapperMock.Setup(m => m.Map<VehicleReturnModel>(It.IsAny<Vehicle>()))
                .Returns(new VehicleReturnModel());
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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            var result = _sut.PostEntity(validModel) as OkObjectResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((VehicleReturnModel)result.Value, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateVehcileReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new VehicleModel
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            var series = new Series();

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateEntity(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateVehicleReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new VehicleModel
            {
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            var series = new Series();

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            var result = _sut.UpdateEntity(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenModelIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1
            };

            var brand = new Brand();
            Model model = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenFuelTypeIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1
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

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenMotorTypeIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            EngineType engineType = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);
            _modelRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(model);
            _fuelTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelType);
            _engineTypeRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(engineType);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenDoorTypeIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
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

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenCategoryIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1,
                CategoryId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
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

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenFuelcardIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            FuelCard fuelCard = null;

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Never);
        }

        [Test]
        public void UpdateVehicleReturnsNotFoundWhenSerieIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                EnginePower = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            Series series = null;

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdatevehicleReturnsNotFoundWhenVehicleIsNotFound()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            var series = new Series();

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateVehicleReturnsBadRequestWhenFuelCardIsAlreadyPresentAndIsntFromUpdatingVehicle()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            var series = new Series();
            var vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    Id = validModel.Id + 1
                }
            };

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);
            _vehicleRepositoryMock.Setup(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .Returns(vehicles);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void UpdateVehicleReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new VehicleModel
            {
                Id = 1,
                BrandId = 1,
                ModelId = 1,
                FuelTypeId = 1,
                EngineTypeId = 1,
                DoorTypeId = 1,
                Emission = 1,
                FiscalHP = 1,
                EnginePower = 1,
                Volume = 1,
                CategoryId = 1,
                FuelCardId = 1,
                SeriesId = 1
            };

            var brand = new Brand();
            var model = new Model
            {
                Brand = new Brand()
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = new Brand()
            };
            var doorType = new DoorType();
            var category = new Category();
            var fuelCard = new FuelCard();
            var series = new Series();

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
            _fuelcardRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(fuelCard);
            _serieRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(series);

            var result = _sut.UpdateEntity(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Vehicle>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _modelRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _doorTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _engineTypeRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _categoryRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _fuelcardRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _serieRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Find(It.IsAny<Expression<Func<Vehicle, bool>>>()), Times.Once);
        }

        [Test]
        public void DeleteVehicleReturnsNotFoundWhenVehicleIsNotFound()
        {
            Vehicle vehicle = null;

            _vehicleRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(vehicle);

            var result = _sut.DeleteEntity(1) as NotFoundObjectResult;

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

            var result = _sut.DeleteEntity(1) as OkResult;

            Assert.That(result, Is.Not.Null);

            _vehicleRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
            _vehicleRepositoryMock.Verify(m => m.Remove(It.IsAny<Vehicle>()), Times.Once);
        }
    }
}