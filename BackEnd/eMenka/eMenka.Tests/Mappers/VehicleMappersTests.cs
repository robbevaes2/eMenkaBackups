using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers
{
    [TestFixture]
    public class VehicleMappersTests
    {
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
            int id = 1;
            int emission = 1;
            int fiscalhp = 1;
            bool isActive = true;
            int power = 1;
            int volume = 1;
            string licensePlate = "plate";
            string chassis = "chassis";
            int averageFuel = 1;
            DateTime enDateDelivery = DateTime.Now;
            int engineCapacity = 1;
            int enginePower = 1;
            int buildYear = 2000;

            Vehicle vehicle = new Vehicle
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

            VehicleReturnModel result = VehicleMappers.MapVehicleEntity(vehicle);

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
            int id = 1;
            int emission = 1;
            int fiscalhp = 1;
            bool isActive = true;
            int power = 1;
            int volume = 1;
            string licensePlate = "plate";
            string chassis = "chassis";
            int averageFuel = 1;
            DateTime enDateDelivery = DateTime.Now;
            int engineCapacity = 1;
            int enginePower = 1;
            int buildYear = 2000;
            int engineTypeId = 1;
            int brandId = 1;
            int doortypeId = 1;
            int fuelTypeId = 1;
            int modelId = 1;
            int fuelCardId = 1;
            int seriesId = 1;
            int countryId = 1;
            int categoryId = 1;

            VehicleModel vehicle = new VehicleModel
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

            Vehicle result = VehicleMappers.MapVehicleModel(vehicle);

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
            string name = "name";
            int id = 1;

            Series series = new Series
            {
                Brand = null,
                Id = id,
                Name = name
            };

            SerieReturnModel result = VehicleMappers.MapSerieEntity(series);

            Assert.That(result.Brand, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapSerieModelReturnsSeriesWithCorrectProperties()
        {
            string name = "name";
            int id = 1;
            int brandid = 1;

            SerieModel serieModel = new SerieModel
            {
                BrandId = brandid,
                Id = id,
                Name = name
            };

            Series result = VehicleMappers.MapSerieModel(serieModel);

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
            string name = "name";
            int id = 1;

            EngineType engineType = new EngineType()
            {
                Brand = null,
                Id = id,
                Name = name
            };

            EngineTypeReturnModel result = VehicleMappers.MapEngineTypeEntity(engineType);

            Assert.That(result.Brand, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapEngineTypeModelReturnsEngineTypeWithCorrectProperties()
        {
            string name = "name";
            int id = 1;
            int brandid = 1;

            EngineTypeModel engineTypeModel = new EngineTypeModel()
            {
                BrandId = brandid,
                Id = id,
                Name = name
            };

            EngineType result = VehicleMappers.MapEngineTypeModel(engineTypeModel);

            Assert.That(result.BrandId, Is.EqualTo(brandid));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapModelEntityReturnNullWhenModelIsNull()
        {
            Model model = null;

            var result = VehicleMappers.MapModelEntity(model);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapModelEntityReturnsReturnModelWithCorrectProperties()
        {
            string name = "name";
            int id = 1;

            Model model = new Model()
            {
                Brand = null,
                Id = id,
                Name = name
            };

            ModelReturnModel result = VehicleMappers.MapModelEntity(model);

            Assert.That(result.Brand, Is.Null);
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapModelModelReturnsModelWithCorrectProperties()
        {
            string name = "name";
            int id = 1;
            int brandid = 1;

            ModelModel modelModel = new ModelModel()
            {
                BrandId = brandid,
                Id = id,
                Name = name
            };

            Model result = VehicleMappers.MapModelModel(modelModel);

            Assert.That(result.BrandId, Is.EqualTo(brandid));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapbrandEntityReturnNullWhenModelIsNull()
        {
            Brand brand = null;

            var result = VehicleMappers.MapBrandEntity(brand);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void MapBrandEntityReturnsReturnModelWithCorrectProperties()
        {
            string name = "name";
            int id = 1;

            Brand brand = new Brand()
            {
                Id = id,
                Name = name
            };

            BrandReturnModel result = VehicleMappers.MapBrandEntity(brand);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapBrandModelReturnsBrandWithCorrectProperties()
        {
            string name = "name";
            int id = 1;

            BrandModel brandModel = new BrandModel()
            {
                Id = id,
                Name = name
            };

            Brand result = VehicleMappers.MapBrandModel(brandModel);

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
            string name = "name";
            int id = 1;
            string code = "code";

            FuelType fuelType = new FuelType()
            {
                Id = id,
                Name = name,
                Code = code
            };

            FuelTypeReturnModel result = VehicleMappers.MapFuelTypeEntity(fuelType);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
        }

        [Test]
        public void MapFuelTypeModelReturnsBrandWithCorrectProperties()
        {
            string name = "name";
            int id = 1;
            string code = "code";

            FuelTypeModel fuelTypeModel = new FuelTypeModel()
            {
                Id = id,
                Name = name,
                Code = code
            };

            FuelType result = VehicleMappers.MapFuelTypeModel(fuelTypeModel);

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
            string name = "name";
            int id = 1;

            DoorType doorType = new DoorType()
            {
                Id = id,
                Name = name
            };

            DoorTypeReturnModel result = VehicleMappers.MapDoorTypeEntity(doorType);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapDoorTypeModelReturnsDoorTypeWithCorrectProperties()
        {
            string name = "name";
            int id = 1;

            DoorTypeModel doorTypeModel = new DoorTypeModel()
            {
                Id = id,
                Name = name
            };

            DoorType result = VehicleMappers.MapDoorTypeModel(doorTypeModel);

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
            string name = "name";
            int id = 1;

            Category category = new Category()
            {
                Id = id,
                Name = name
            };

            CategoryReturnModel result = VehicleMappers.MapCategoryEntity(category);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
        }

        [Test]
        public void MapCategoryModelReturnsCategoryWithCorrectProperties()
        {
            string name = "name";
            int id = 1;

            CategoryModel categoryModel = new CategoryModel()
            {
                Id = id,
                Name = name
            };

            Category result = VehicleMappers.MapCategoryModel(categoryModel);

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
            string name = "name";
            int id = 1;
            string code = "code";
            bool isActive = true;
            string nationality = "nation";
            bool pod = true;

            Country country = new Country()
            {
                Id = id,
                Name = name,
                IsActive = isActive,
                Code = code,
                Nationality = nationality,
                POD = pod
            };

            CountryReturnModel result = VehicleMappers.MapCountryEntity(country);

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
            string name = "name";
            int id = 1;
            string code = "code";
            bool isActive = true;
            string nationality = "nation";
            bool pod = true;

            CountryModel countryModel = new CountryModel()
            {
                Id = id,
                Name = name,
                IsActive = isActive,
                Code = code,
                Nationality = nationality,
                POD = pod
            };

            Country result = VehicleMappers.MapCountryModel(countryModel);

            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.Code, Is.EqualTo(code));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.Nationality, Is.EqualTo(nationality));
            Assert.That(result.POD, Is.EqualTo(pod));
        }
    }


}
