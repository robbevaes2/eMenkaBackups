using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;
using System.Linq;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class FuelCardRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new FuelCardRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private FuelCardRepository _sut;

        [Test]
        public void GetAllIncludesAllRelationsOfFuelCard()
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
                InteriorColor = interiorColor
            };
            var fuelCard = new FuelCard
            {
                Driver = driver,
                Vehicle = vehicle
            };

            _sut.Add(fuelCard);

            var fuelCards = _sut.GetAll();

            Assert.That(fuelCards, Is.Not.Null);

            var fuelCardFromDatabase = fuelCards.FirstOrDefault(fc => fc.Id == fuelCard.Id);

            Assert.That(fuelCardFromDatabase.Vehicle.Brand, Is.EqualTo(brand));
            Assert.That(fuelCardFromDatabase.Vehicle.Model, Is.EqualTo(model));
            Assert.That(fuelCardFromDatabase.Vehicle.FuelType, Is.EqualTo(fuelType));
            Assert.That(fuelCardFromDatabase.Vehicle.EngineType, Is.EqualTo(engineType));
            Assert.That(fuelCardFromDatabase.Vehicle.Series, Is.EqualTo(series));
            Assert.That(fuelCardFromDatabase.Vehicle.DoorType, Is.EqualTo(doorType));
            Assert.That(fuelCardFromDatabase.Vehicle.Category, Is.EqualTo(category));
            Assert.That(fuelCardFromDatabase.Vehicle.Country, Is.EqualTo(country));
            Assert.That(fuelCardFromDatabase.Vehicle.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(fuelCardFromDatabase.Vehicle.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(fuelCardFromDatabase.Vehicle.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(fuelCardFromDatabase.Driver, Is.EqualTo(driver));
            Assert.That(fuelCardFromDatabase.Driver.Person, Is.EqualTo(person));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfFuelCard()
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
                InteriorColor = interiorColor
            };
            var fuelCard = new FuelCard
            {
                Driver = driver,
                Vehicle = vehicle
            };

            _sut.Add(fuelCard);

            var fuelCardFromDatabase = _sut.GetById(fuelCard.Id);

            Assert.That(fuelCardFromDatabase.Vehicle.Brand, Is.EqualTo(brand));
            Assert.That(fuelCardFromDatabase.Vehicle.Model, Is.EqualTo(model));
            Assert.That(fuelCardFromDatabase.Vehicle.FuelType, Is.EqualTo(fuelType));
            Assert.That(fuelCardFromDatabase.Vehicle.EngineType, Is.EqualTo(engineType));
            Assert.That(fuelCardFromDatabase.Vehicle.Series, Is.EqualTo(series));
            Assert.That(fuelCardFromDatabase.Vehicle.DoorType, Is.EqualTo(doorType));
            Assert.That(fuelCardFromDatabase.Vehicle.Category, Is.EqualTo(category));
            Assert.That(fuelCardFromDatabase.Vehicle.Country, Is.EqualTo(country));
            Assert.That(fuelCardFromDatabase.Vehicle.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(fuelCardFromDatabase.Vehicle.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(fuelCardFromDatabase.Vehicle.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(fuelCardFromDatabase.Driver, Is.EqualTo(driver));
            Assert.That(fuelCardFromDatabase.Driver.Person, Is.EqualTo(person));
        }

        [Test]
        public void FindIncludesAllRelationsOfFuelCard()
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
                InteriorColor = interiorColor
            };
            var fuelCard = new FuelCard
            {
                Driver = driver,
                Vehicle = vehicle
            };

            _sut.Add(fuelCard);

            var fuelCardFromDatabase = _sut.Find(fc => fc.Id == fuelCard.Id).FirstOrDefault();

            Assert.That(fuelCardFromDatabase.Vehicle.Brand, Is.EqualTo(brand));
            Assert.That(fuelCardFromDatabase.Vehicle.Model, Is.EqualTo(model));
            Assert.That(fuelCardFromDatabase.Vehicle.FuelType, Is.EqualTo(fuelType));
            Assert.That(fuelCardFromDatabase.Vehicle.EngineType, Is.EqualTo(engineType));
            Assert.That(fuelCardFromDatabase.Vehicle.Series, Is.EqualTo(series));
            Assert.That(fuelCardFromDatabase.Vehicle.DoorType, Is.EqualTo(doorType));
            Assert.That(fuelCardFromDatabase.Vehicle.Category, Is.EqualTo(category));
            Assert.That(fuelCardFromDatabase.Vehicle.Country, Is.EqualTo(country));
            Assert.That(fuelCardFromDatabase.Vehicle.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(fuelCardFromDatabase.Vehicle.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(fuelCardFromDatabase.Vehicle.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(fuelCardFromDatabase.Driver, Is.EqualTo(driver));
            Assert.That(fuelCardFromDatabase.Driver.Person, Is.EqualTo(person));
        }
    }
}