using System.Linq;
using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class VehicleRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new VehicleRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private VehicleRepository _sut;

        [Test]
        public void GetAllIncludesAllRelationsOfVehicle()
        {
            var brand = new Brand();
            var model = new Model
            {
                Brand = brand
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = brand
            };
            var series = new Series
            {
                Brand = brand
            };
            var doorType = new DoorType();
            var category = new Category();
            var country = new Country();
            var exteriorColor = new ExteriorColor
            {
                Brand = brand
            };
            var interiorColor = new InteriorColor
            {
                Brand = brand
            };
            var person = new Person();
            var driver = new Driver
            {
                Person = person
            };
            var fuelCard = new FuelCard
            {
                Driver = driver
            };
            var vehicle = new Vehicle
            {
                Brand = brand,
                Model = model,
                FuelType = fuelType,
                EngineType = engineType,
                Series = series,
                DoorType = doorType,
                Category = category,
                Country = country,
                ExteriorColor = exteriorColor,
                InteriorColor = interiorColor,
                FuelCard = fuelCard
            };

            _sut.Add(vehicle);

            var vehicles = _sut.GetAll();

            Assert.That(vehicles, Is.Not.Null);

            var vehicleFromDatabase = vehicles.FirstOrDefault(v => v.Id == vehicle.Id);

            Assert.That(vehicleFromDatabase.Brand, Is.EqualTo(brand));
            Assert.That(vehicleFromDatabase.Model, Is.EqualTo(model));
            Assert.That(vehicleFromDatabase.FuelType, Is.EqualTo(fuelType));
            Assert.That(vehicleFromDatabase.EngineType, Is.EqualTo(engineType));
            Assert.That(vehicleFromDatabase.Series, Is.EqualTo(series));
            Assert.That(vehicleFromDatabase.DoorType, Is.EqualTo(doorType));
            Assert.That(vehicleFromDatabase.Category, Is.EqualTo(category));
            Assert.That(vehicleFromDatabase.Country, Is.EqualTo(country));
            Assert.That(vehicleFromDatabase.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(vehicleFromDatabase.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(vehicleFromDatabase.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(vehicleFromDatabase.FuelCard.Driver, Is.EqualTo(driver));
            Assert.That(vehicleFromDatabase.FuelCard.Driver.Person, Is.EqualTo(person));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfVehicle()
        {
            var brand = new Brand();
            var model = new Model
            {
                Brand = brand
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = brand
            };
            var series = new Series
            {
                Brand = brand
            };
            var doorType = new DoorType();
            var category = new Category();
            var country = new Country();
            var exteriorColor = new ExteriorColor
            {
                Brand = brand
            };
            var interiorColor = new InteriorColor
            {
                Brand = brand
            };
            var person = new Person();
            var driver = new Driver
            {
                Person = person
            };
            var fuelCard = new FuelCard
            {
                Driver = driver
            };
            var vehicle = new Vehicle
            {
                Brand = brand,
                Model = model,
                FuelType = fuelType,
                EngineType = engineType,
                Series = series,
                DoorType = doorType,
                Category = category,
                Country = country,
                ExteriorColor = exteriorColor,
                InteriorColor = interiorColor,
                FuelCard = fuelCard
            };

            _sut.Add(vehicle);

            var vehicleFromDatabase = _sut.GetById(vehicle.Id);

            Assert.That(vehicleFromDatabase.Brand, Is.EqualTo(brand));
            Assert.That(vehicleFromDatabase.Model, Is.EqualTo(model));
            Assert.That(vehicleFromDatabase.FuelType, Is.EqualTo(fuelType));
            Assert.That(vehicleFromDatabase.EngineType, Is.EqualTo(engineType));
            Assert.That(vehicleFromDatabase.Series, Is.EqualTo(series));
            Assert.That(vehicleFromDatabase.DoorType, Is.EqualTo(doorType));
            Assert.That(vehicleFromDatabase.Category, Is.EqualTo(category));
            Assert.That(vehicleFromDatabase.Country, Is.EqualTo(country));
            Assert.That(vehicleFromDatabase.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(vehicleFromDatabase.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(vehicleFromDatabase.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(vehicleFromDatabase.FuelCard.Driver, Is.EqualTo(driver));
            Assert.That(vehicleFromDatabase.FuelCard.Driver.Person, Is.EqualTo(person));
        }

        [Test]
        public void FindIncludesAllRelationsOfVehicle()
        {
            var brand = new Brand();
            var model = new Model
            {
                Brand = brand
            };
            var fuelType = new FuelType();
            var engineType = new EngineType
            {
                Brand = brand
            };
            var series = new Series
            {
                Brand = brand
            };
            var doorType = new DoorType();
            var category = new Category();
            var country = new Country();
            var exteriorColor = new ExteriorColor
            {
                Brand = brand
            };
            var interiorColor = new InteriorColor
            {
                Brand = brand
            };
            var person = new Person();
            var driver = new Driver
            {
                Person = person
            };
            var fuelCard = new FuelCard
            {
                Driver = driver
            };
            var vehicle = new Vehicle
            {
                Brand = brand,
                Model = model,
                FuelType = fuelType,
                EngineType = engineType,
                Series = series,
                DoorType = doorType,
                Category = category,
                Country = country,
                ExteriorColor = exteriorColor,
                InteriorColor = interiorColor,
                FuelCard = fuelCard
            };

            _sut.Add(vehicle);

            var vehicleFromDatabase = _sut.Find(v => v.Id == vehicle.Id).FirstOrDefault();

            Assert.That(vehicleFromDatabase.Brand, Is.EqualTo(brand));
            Assert.That(vehicleFromDatabase.Model, Is.EqualTo(model));
            Assert.That(vehicleFromDatabase.FuelType, Is.EqualTo(fuelType));
            Assert.That(vehicleFromDatabase.EngineType, Is.EqualTo(engineType));
            Assert.That(vehicleFromDatabase.Series, Is.EqualTo(series));
            Assert.That(vehicleFromDatabase.DoorType, Is.EqualTo(doorType));
            Assert.That(vehicleFromDatabase.Category, Is.EqualTo(category));
            Assert.That(vehicleFromDatabase.Country, Is.EqualTo(country));
            Assert.That(vehicleFromDatabase.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(vehicleFromDatabase.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(vehicleFromDatabase.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(vehicleFromDatabase.FuelCard.Driver, Is.EqualTo(driver));
            Assert.That(vehicleFromDatabase.FuelCard.Driver.Person, Is.EqualTo(person));
        }
    }
}