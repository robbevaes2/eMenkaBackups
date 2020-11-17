using System;
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
        private Mock<IMotorTypeRepository> _motorTypeRepositoryMock;
        private Mock<IDoorTypeRepository> _doorTypeRepositoryMock;

        [SetUp]
        public void Init()
        {
            _vehicleRepositoryMock = new Mock<IVehicleRepository>();
            _brandRepositoryMock = new Mock<IBrandRepository>();
            _motorTypeRepositoryMock = new Mock<IMotorTypeRepository>();
            _modelRepositoryMock = new Mock<IModelRepository>();
            _fuelTypeRepositoryMock = new Mock<IFuelTypeRepository>();
            _doorTypeRepositoryMock = new Mock<IDoorTypeRepository>();

            _sut = new VehicleController(_vehicleRepositoryMock.Object, _brandRepositoryMock.Object, _modelRepositoryMock.Object, _fuelTypeRepositoryMock.Object, _motorTypeRepositoryMock.Object, _doorTypeRepositoryMock.Object);
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
                MotorType = new MotorType
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

        /*

        [Test]
        public void PostSerieReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new SerieModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.PostSerie(invalidModel) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Add(It.IsAny<Serie>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void PostSerieReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new SerieModel
            {
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostSerie(validModel) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Add(It.IsAny<Serie>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void PostSerieReturnsOkWhenModelIsValid()
        {
            var validModel = new SerieModel
            {
                Name = "name",
                BrandId = 1
            };

            var brand = new Brand();

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.PostSerie(validModel) as OkResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Add(It.IsAny<Serie>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateSerieReturnsBadRequestWhenModelIsInvalid()
        {
            var invalidModel = new SerieModel();

            _sut.ModelState.AddModelError("name", "name is required");

            var result = _sut.UpdateSerie(invalidModel, 1) as BadRequestResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Serie>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateSerieReturnsBadRequestWhenIdFromModelDoesNotMatchIdFromQueryParameter()
        {
            var invalidModel = new SerieModel
            {
                Id = 1
            };

            var result = _sut.UpdateSerie(invalidModel, invalidModel.Id + 1) as BadRequestObjectResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Serie>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void UpdateSerieReturnsNotFoundWhenBrandIsNotFound()
        {
            var validModel = new SerieModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            Brand brand = null;

            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateSerie(validModel, validModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Serie>()), Times.Never);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateSerieReturnsNotFoundWhenSerieIsNotFound()
        {
            var invalidModel = new SerieModel
            {
                Id = 1,
                BrandId = 1
            };

            var brand = new Brand();

            _serieRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Serie>()))
                .Returns(false);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateSerie(invalidModel, invalidModel.Id) as NotFoundObjectResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Serie>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UpdateSerieReturnsOkWhenEverythingIsCorrect()
        {
            var validModel = new SerieModel
            {
                Id = 1,
                Name = "",
                BrandId = 1
            };

            var brand = new Brand();

            _serieRepositoryMock.Setup(m => m.Update(It.IsAny<int>(), It.IsAny<Serie>()))
                .Returns(true);
            _brandRepositoryMock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(brand);

            var result = _sut.UpdateSerie(validModel, validModel.Id) as OkResult;

            Assert.That(result, Is.Not.Null);

            _serieRepositoryMock.Verify(m => m.Update(It.IsAny<int>(), It.IsAny<Serie>()), Times.Once);
            _brandRepositoryMock.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }*/

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
