using System.Collections.Generic;
using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;
using System.Linq;

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
        public void GetAllAvailableDriverReturnsAllDriversWithoutAFuelCard()
        {
            var vehicles = _sut.GetAllAvailableVehicles();

            foreach (var vehicle in vehicles)
            {
                Assert.That(vehicle.FuelCardId, Is.Null);
            }
        }

        [Test]
        public void GetAllAvailableVehiclesByBrandIdReturnsAllDriversFromBrandWithAFuelCardThatIsNotInUse()
        {
            int brandid = 1;
            int usedFuelCardId = 1;
            var fuelCardsInRecord = new List<int?>
            {
                usedFuelCardId
            };
            var vehicles = _sut.GetAllAvailableVehiclesByBrandId(brandid, fuelCardsInRecord);

            foreach (var vehicle in vehicles)
            {
                Assert.That(vehicle.FuelCardId, Is.Not.Null);
                Assert.That(vehicle.BrandId, Is.EqualTo(brandid));
                Assert.That(vehicle.FuelCardId, Is.Not.EqualTo(usedFuelCardId));
            }
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