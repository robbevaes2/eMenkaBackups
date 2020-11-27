using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Mappers.VehicleMappers;
using eMenka.API.Models.VehicleModels;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Mappers.VehicleMappers
{
    [TestFixture]
    public class VehicleMapperTest
    {
        private VehicleMapper _sut;

        [SetUp]
        public void Init()
        {
            _sut = new VehicleMapper();
        }

        [Test]
        public void MapVehicleEntityReturnNullWhenVehicleIsNull()
        {
            Vehicle vehicle = null;

            var result = _sut.MapEntityToReturnModel(vehicle);

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
            var kilometers = 1000;
            var registrationDate = DateTime.Now;

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
                BuildYear = buildYear,
                Kilometers = kilometers,
                RegistrationDate = registrationDate,
                ExteriorColor = null,
                InteriorColor = null
            };

            var result = _sut.MapEntityToReturnModel(vehicle);

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
            Assert.That(result.Kilometers, Is.EqualTo(kilometers));
            Assert.That(result.RegistrationDate, Is.EqualTo(registrationDate));
            Assert.That(result.Brand, Is.Null);
            Assert.That(result.FuelCard, Is.Null);
            Assert.That(result.FuelType, Is.Null);
            Assert.That(result.EngineType, Is.Null);
            Assert.That(result.DoorType, Is.Null);
            Assert.That(result.Model, Is.Null);
            Assert.That(result.Serie, Is.Null);
            Assert.That(result.Country, Is.Null);
            Assert.That(result.Category, Is.Null);
            Assert.That(result.InteriorColor, Is.Null);
            Assert.That(result.ExteriorColor, Is.Null);
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
            var kilometers = 1000;
            var engineTypeId = 1;
            var brandId = 1;
            var doortypeId = 1;
            var fuelTypeId = 1;
            var modelId = 1;
            var fuelCardId = 1;
            var seriesId = 1;
            var countryId = 1;
            var categoryId = 1;
            var registrationDate = DateTime.Now;
            var exteriorColorId = 1;
            var interiorColorId = 1;

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
                ModelId = modelId,
                Kilometers = kilometers,
                RegistrationDate = registrationDate,
                ExteriorColorId = exteriorColorId,
                InteriorColorId = interiorColorId
            };

            var result = _sut.MapModelToEntity(vehicle);

            Assert.That(result.AverageFuel, Is.EqualTo(averageFuel));
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.Emission, Is.EqualTo(emission));
            Assert.That(result.FiscalHP, Is.EqualTo(fiscalhp));
            Assert.That(result.IsActive, Is.EqualTo(isActive));
            Assert.That(result.Volume, Is.EqualTo(volume));
            Assert.That(result.LicensePlate, Is.EqualTo(licensePlate));
            Assert.That(result.Chassis, Is.EqualTo(chassis));
            Assert.That(result.EndDateDelivery, Is.EqualTo(enDateDelivery));
            Assert.That(result.EngineCapacity, Is.EqualTo(engineCapacity));
            Assert.That(result.EnginePower, Is.EqualTo(enginePower));
            Assert.That(result.BuildYear, Is.EqualTo(buildYear));
            Assert.That(result.Kilometers, Is.EqualTo(kilometers));
            Assert.That(result.RegistrationDate, Is.EqualTo(registrationDate));
            Assert.That(result.FuelCardId, Is.EqualTo(fuelCardId));
            Assert.That(result.BrandId, Is.EqualTo(brandId));
            Assert.That(result.SeriesId, Is.EqualTo(seriesId));
            Assert.That(result.CategoryId, Is.EqualTo(categoryId));
            Assert.That(result.CountryId, Is.EqualTo(countryId));
            Assert.That(result.DoorTypeId, Is.EqualTo(doortypeId));
            Assert.That(result.EngineTypeId, Is.EqualTo(engineTypeId));
            Assert.That(result.FuelTypeId, Is.EqualTo(fuelTypeId));
            Assert.That(result.ModelId, Is.EqualTo(modelId));
            Assert.That(result.ExteriorColorId, Is.EqualTo(exteriorColorId));
            Assert.That(result.InteriorColorId, Is.EqualTo(interiorColorId));
        }
    }
}
