using NUnit.Framework;

namespace eMenka.Tests.Mappers
{
    [TestFixture]
    public class VehicleMappersTests
    {
        /*
        [Test]
        public void MapVehicleEntityReturnNullWhenVehicleIsNull()
        {
            Vehicle vehicle = null;

            var result = VehicleMappers.MapVehicleEntity(vehicle);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapVehicleEntityReturnsReturnModelWithCorrectProperties()
        {
            var id = 1;
            var emission = 1;
            var fiscalhp = 1;
            var isActive = true;
            var power = 1;
            var volume = 1;
            var licensePlate = "plate";
            var chassis = "chassis";
            var averageFuel = 1;
            var enDateDelivery = DateTime.Now;
            var engineCapacity = 1;
            var enginePower = 1;
            var buildYear = 2000;

            var vehicle = new Vehicle
            {
                AverageFuel = averageFuel,
                Brand = null,
                Category = null,
                Id = id,
                FuelType = null,
                EngineType = null,
                DoorType = null,
                Emission = emission,
                FiscalHP = fiscalhp,
                IsActive = isActive,
                Power = power,
                Volume = volume,
                Model = null,
                FuelCard = null,
                LicensePlate = licensePlate,
                Chassis = chassis,
                EndDateDelivery = enDateDelivery,
                EngineCapacity = engineCapacity,
                EnginePower = enginePower,
                Series = null,
                Country = null,
                BuildYear = buildYear
            };

            var result = VehicleMappers.MapVehicleEntity(vehicle);

            Assert.That(result.AverageFuel, Is.EqualTo(averageFuel));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Emission, Is.EqualTo(emission));
            Assert.That(result.FiscalHP, Is.EqualTo(fiscalhp));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.Power, Is.EqualTo(power));
            Assert.That(result.Volume, Is.EqualTo(volume));
            Assert.That(result.LicensePlate, Is.EqualTo(licensePlate));
            Assert.That(result.Chassis, Is.EqualTo(chassis));
            Assert.That(result.EndDateDelivery, Is.EqualTo(enDateDelivery));
            Assert.That(result.EngineCapacity, Is.EqualTo(engineCapacity));
            Assert.That(result.EnginePower, Is.EqualTo(enginePower));
            Assert.That(result.BuildYear, Is.EqualTo(buildYear));
            Assert.That(result.Brand, Is.Null);
            Assert.That(result.FuelCard, Is.Null);
            Assert.That(result.FuelType, Is.Null);
            Assert.That(result.EngineType, Is.Null);
            Assert.That(result.DoorType, Is.Null);
            Assert.That(result.Model, Is.Null);
            Assert.That(result.Serie, Is.Null);
            Assert.That(result.Country, Is.Null);
            Assert.That(result.Category, Is.Null);
        }

        [Test]
        public void MapVehicleModelReturnsVehicleWithCorrectProperties()
        {
            var id = 1;
            var emission = 1;
            var fiscalhp = 1;
            var isActive = true;
            var power = 1;
            var volume = 1;
            var licensePlate = "plate";
            var chassis = "chassis";
            var averageFuel = 1;
            var enDateDelivery = DateTime.Now;
            var engineCapacity = 1;
            var enginePower = 1;
            var buildYear = 2000;
            var engineTypeId = 1;
            var brandId = 1;
            var doortypeId = 1;
            var fuelTypeId = 1;
            var modelId = 1;
            var fuelCardId = 1;
            var seriesId = 1;
            var countryId = 1;
            var categoryId = 1;

            var vehicle = new VehicleModel
            {
                AverageFuel = averageFuel,
                Id = id,
                Emission = emission,
                FiscalHP = fiscalhp,
                IsActive = isActive,
                Power = power,
                Volume = volume,
                LicensePlate = licensePlate,
                Chassis = chassis,
                EndDateDelivery = enDateDelivery,
                EngineCapacity = engineCapacity,
                EnginePower = enginePower,
                BuildYear = buildYear,
                FuelCardId = fuelCardId,
                BrandId = brandId,
                SeriesId = seriesId,
                CategoryId = categoryId,
                CountryId = countryId,
                DoorTypeId = doortypeId,
                EngineTypeId = engineTypeId,
                FuelTypeId = fuelTypeId,
                ModelId = modelId
            };

            var result = VehicleMappers.MapVehicleModel(vehicle);

            Assert.That(result.AverageFuel, Is.EqualTo(averageFuel));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Emission, Is.EqualTo(emission));
            Assert.That(result.FiscalHP, Is.EqualTo(fiscalhp));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.Power, Is.EqualTo(power));
            Assert.That(result.Volume, Is.EqualTo(volume));
            Assert.That(result.LicensePlate, Is.EqualTo(licensePlate));
            Assert.That(result.Chassis, Is.EqualTo(chassis));
            Assert.That(result.EndDateDelivery, Is.EqualTo(enDateDelivery));
            Assert.That(result.EngineCapacity, Is.EqualTo(engineCapacity));
            Assert.That(result.EnginePower, Is.EqualTo(enginePower));
            Assert.That(result.BuildYear, Is.EqualTo(buildYear));
            Assert.That(result.FuelCardId, Is.EqualTo(fuelCardId));
            Assert.That(result.BrandId, Is.EqualTo(brandId));
            Assert.That(result.SeriesId, Is.EqualTo(seriesId));
            Assert.That(result.CategoryId, Is.EqualTo(categoryId));
            Assert.That(result.CountryId, Is.EqualTo(countryId));
            Assert.That(result.DoorTypeId, Is.EqualTo(doortypeId));
            Assert.That(result.EngineTypeId, Is.EqualTo(engineTypeId));
            Assert.That(result.FuelTypeId, Is.EqualTo(fuelTypeId));
            Assert.That(result.ModelId, Is.EqualTo(modelId));
        }

        [Test]
        public void MapSerieEntityReturnNullWhenSerieIsNull()
        {
            Series series = null;

            var result = VehicleMappers.MapSerieEntity(series);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapSerieEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var series = new Series
            {
                Brand = null,
                Id = id,
                Name = name
            };

            var result = VehicleMappers.MapSerieEntity(series);

            Assert.That(result.Brand, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapSerieModelReturnsSeriesWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var brandid = 1;

            var serieModel = new SerieModel
            {
                BrandId = brandid,
                Id = id,
                Name = name
            };

            var result = VehicleMappers.MapSerieModel(serieModel);

            Assert.That(result.BrandId, Is.EqualTo(brandid));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapEngineTypeEntityReturnNullWhenEngineTypeIsNull()
        {
            EngineType engineType = null;

            var result = VehicleMappers.MapEngineTypeEntity(engineType);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapEngineTypeEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var engineType = new EngineType
            {
                Brand = null,
                Id = id,
                Name = name
            };

            var result = VehicleMappers.MapEngineTypeEntity(engineType);

            Assert.That(result.Brand, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapEngineTypeModelReturnsEngineTypeWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var brandid = 1;

            var engineTypeModel = new EngineTypeModel
            {
                BrandId = brandid,
                Id = id,
                Name = name
            };

            var result = VehicleMappers.MapEngineTypeModel(engineTypeModel);

            Assert.That(result.BrandId, Is.EqualTo(brandid));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapFuelTypeEntityReturnNullWhenModelIsNull()
        {
            FuelType fuelType = null;

            var result = VehicleMappers.MapFuelTypeEntity(fuelType);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapFuelTypeEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var code = "code";

            var fuelType = new FuelType
            {
                Id = id,
                Name = name,
                Code = code
            };

            var result = VehicleMappers.MapFuelTypeEntity(fuelType);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
        }

        [Test]
        public void MapFuelTypeModelReturnsBrandWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var code = "code";

            var fuelTypeModel = new FuelTypeModel
            {
                Id = id,
                Name = name,
                Code = code
            };

            var result = VehicleMappers.MapFuelTypeModel(fuelTypeModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
        }

        [Test]
        public void MapDoorTypeEntityReturnNullWhenModelIsNull()
        {
            DoorType doorType = null;

            var result = VehicleMappers.MapDoorTypeEntity(doorType);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapDoorTypeEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var doorType = new DoorType
            {
                Id = id,
                Name = name
            };

            var result = VehicleMappers.MapDoorTypeEntity(doorType);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapDoorTypeModelReturnsDoorTypeWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var doorTypeModel = new DoorTypeModel
            {
                Id = id,
                Name = name
            };

            var result = VehicleMappers.MapDoorTypeModel(doorTypeModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapCategoryEntityReturnNullWhenModelIsNull()
        {
            Category category = null;

            var result = VehicleMappers.MapCategoryEntity(category);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapCategoryEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var category = new Category
            {
                Id = id,
                Name = name
            };

            var result = VehicleMappers.MapCategoryEntity(category);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapCategoryModelReturnsCategoryWithCorrectProperties()
        {
            var name = "name";
            var id = 1;

            var categoryModel = new CategoryModel
            {
                Id = id,
                Name = name
            };

            var result = VehicleMappers.MapCategoryModel(categoryModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapCountryEntityReturnNullWhenModelIsNull()
        {
            Country country = null;

            var result = VehicleMappers.MapCountryEntity(country);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapCountryEntityReturnsReturnModelWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var code = "code";
            var isActive = true;
            var nationality = "nation";
            var pod = true;

            var country = new Country
            {
                Id = id,
                Name = name,
                IsActive = isActive,
                Code = code,
                Nationality = nationality,
                POD = pod
            };

            var result = VehicleMappers.MapCountryEntity(country);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.Nationality, Is.EqualTo(nationality));
            Assert.That(result.POD, Is.EqualTo(pod));
        }

        [Test]
        public void MapCountryModelReturnsCategoryWithCorrectProperties()
        {
            var name = "name";
            var id = 1;
            var code = "code";
            var isActive = true;
            var nationality = "nation";
            var pod = true;

            var countryModel = new CountryModel
            {
                Id = id,
                Name = name,
                IsActive = isActive,
                Code = code,
                Nationality = nationality,
                POD = pod
            };

            var result = VehicleMappers.MapCountryModel(countryModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.Nationality, Is.EqualTo(nationality));
            Assert.That(result.POD, Is.EqualTo(pod));
        }*/
    }
}