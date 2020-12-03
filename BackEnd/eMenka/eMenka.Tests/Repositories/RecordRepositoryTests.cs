using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;
using System.Linq;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class RecordRepositoryTests
    {
        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new RecordRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        private RecordRepository _sut;

        [Test]
        public void GetAllIncludesAllRelationsOfRecord()
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

            var costAllocation = new CostAllocation();
            var company = new Company();
            var corporation = new Corporation
            {
                Company = company
            };

            var record = new Record
            {
                FuelCard = fuelCard,
                CostAllocation = costAllocation,
                Corporation = corporation
            };

            _sut.Add(record);

            var records = _sut.GetAll();

            Assert.That(records, Is.Not.Null);

            var recordFromDatabase = records.FirstOrDefault(r => r.Id == record.Id);

            Assert.That(recordFromDatabase.CostAllocation, Is.EqualTo(costAllocation));
            Assert.That(recordFromDatabase.Corporation, Is.EqualTo(corporation));
            Assert.That(recordFromDatabase.Corporation.Company, Is.EqualTo(company));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Brand, Is.EqualTo(brand));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Model, Is.EqualTo(model));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.FuelType, Is.EqualTo(fuelType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.EngineType, Is.EqualTo(engineType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Series, Is.EqualTo(series));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.DoorType, Is.EqualTo(doorType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Category, Is.EqualTo(category));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Country, Is.EqualTo(country));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(recordFromDatabase.FuelCard.Driver, Is.EqualTo(driver));
            Assert.That(recordFromDatabase.FuelCard.Driver.Person, Is.EqualTo(person));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfRecord()
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

            var costAllocation = new CostAllocation();
            var company = new Company();
            var corporation = new Corporation
            {
                Company = company
            };

            var record = new Record
            {
                FuelCard = fuelCard,
                CostAllocation = costAllocation,
                Corporation = corporation
            };

            _sut.Add(record);

            var recordFromDatabase = _sut.GetById(record.Id);

            Assert.That(recordFromDatabase.CostAllocation, Is.EqualTo(costAllocation));
            Assert.That(recordFromDatabase.Corporation, Is.EqualTo(corporation));
            Assert.That(recordFromDatabase.Corporation.Company, Is.EqualTo(company));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Brand, Is.EqualTo(brand));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Model, Is.EqualTo(model));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.FuelType, Is.EqualTo(fuelType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.EngineType, Is.EqualTo(engineType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Series, Is.EqualTo(series));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.DoorType, Is.EqualTo(doorType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Category, Is.EqualTo(category));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Country, Is.EqualTo(country));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(recordFromDatabase.FuelCard.Driver, Is.EqualTo(driver));
            Assert.That(recordFromDatabase.FuelCard.Driver.Person, Is.EqualTo(person));
        }

        [Test]
        public void FindIncludesAllRelationsOfRecord()
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

            var costAllocation = new CostAllocation();
            var company = new Company();
            var corporation = new Corporation
            {
                Company = company
            };

            var record = new Record
            {
                FuelCard = fuelCard,
                CostAllocation = costAllocation,
                Corporation = corporation
            };

            _sut.Add(record);

            var recordFromDatabase = _sut.Find(r => r.Id == record.Id).FirstOrDefault();

            Assert.That(recordFromDatabase.CostAllocation, Is.EqualTo(costAllocation));
            Assert.That(recordFromDatabase.Corporation, Is.EqualTo(corporation));
            Assert.That(recordFromDatabase.Corporation.Company, Is.EqualTo(company));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Brand, Is.EqualTo(brand));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Model, Is.EqualTo(model));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.FuelType, Is.EqualTo(fuelType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.EngineType, Is.EqualTo(engineType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Series, Is.EqualTo(series));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.DoorType, Is.EqualTo(doorType));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Category, Is.EqualTo(category));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.Country, Is.EqualTo(country));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.ExteriorColor, Is.EqualTo(exteriorColor));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.InteriorColor, Is.EqualTo(interiorColor));
            Assert.That(recordFromDatabase.FuelCard.Vehicle.FuelCard, Is.EqualTo(fuelCard));
            Assert.That(recordFromDatabase.FuelCard.Driver, Is.EqualTo(driver));
            Assert.That(recordFromDatabase.FuelCard.Driver.Person, Is.EqualTo(person));
        }
    }
}