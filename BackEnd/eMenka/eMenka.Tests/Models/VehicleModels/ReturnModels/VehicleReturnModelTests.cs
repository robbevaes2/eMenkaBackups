using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Models.VehicleModels.ReturnModels;
using NUnit.Framework;

namespace eMenka.Tests.Models.VehicleModels.ReturnModels
{
    [TestFixture]
    public class VehicleReturnModelTests
    {
        [Test]
        public void AllGettersAndSettersFromPropertiesWork()
        {
            bool isActive = true;
            string licensePlate = "plate";
            string chassiss = "chassiss";
            int engineCapacity = 1;
            int volume = 1;
            int fiscalHP = 400;
            int emission = 100;
            int enginePower = 500;
            DateTime endDateDelivery = DateTime.Now;
            int averageFuel = 100;
            int countryId = 1;
            int buildYear = 2000;
            double kilometers = 100;
            DateTime registrationDate = DateTime.Now;
            int exteriorColor = 2;
            int interiorColor = 5;
            int id = 1;

            var sut = new VehicleReturnModel()
            {
                AverageFuel = averageFuel,
                IsActive = isActive,
                LicensePlate = licensePlate,
                Chassis = chassiss,
                EngineCapacity = engineCapacity,
                Volume = volume,
                FiscalHP = fiscalHP,
                Emission = emission,
                EnginePower = enginePower,
                EndDateDelivery = endDateDelivery,
                BuildYear = buildYear,
                Kilometers = kilometers,
                RegistrationDate = registrationDate,
                Id = id,
                Brand = null,
                Category = null,
                Country = null,
                DoorType = null,
                EngineType = null,
                ExteriorColor = null,
                FuelCard = null,
                FuelType = null,
                InteriorColor = null,
                Model = null,
                Series = null
            };

            Assert.That(sut.AverageFuel, Is.EqualTo(averageFuel));
            Assert.That(sut.IsActive, Is.EqualTo(isActive));
            Assert.That(sut.LicensePlate, Is.EqualTo(licensePlate));
            Assert.That(sut.Chassis, Is.EqualTo(chassiss));
            Assert.That(sut.EngineCapacity, Is.EqualTo(engineCapacity));
            Assert.That(sut.Volume, Is.EqualTo(volume));
            Assert.That(sut.FiscalHP, Is.EqualTo(fiscalHP));
            Assert.That(sut.Emission, Is.EqualTo(emission));
            Assert.That(sut.EnginePower, Is.EqualTo(enginePower));
            Assert.That(sut.EndDateDelivery, Is.EqualTo(endDateDelivery));
            Assert.That(sut.BuildYear, Is.EqualTo(buildYear));
            Assert.That(sut.Kilometers, Is.EqualTo(kilometers));
            Assert.That(sut.RegistrationDate, Is.EqualTo(registrationDate));
            Assert.That(sut.Id, Is.EqualTo(id));
            Assert.That(sut.Brand, Is.Null);
            Assert.That(sut.Category, Is.Null);
            Assert.That(sut.Country, Is.Null);
            Assert.That(sut.DoorType, Is.Null);
            Assert.That(sut.EngineType, Is.Null);
            Assert.That(sut.ExteriorColor, Is.Null);
            Assert.That(sut.FuelCard, Is.Null);
            Assert.That(sut.FuelType, Is.Null);
            Assert.That(sut.InteriorColor, Is.Null);
            Assert.That(sut.Model, Is.Null);
            Assert.That(sut.Series, Is.Null);
        }
    }
}
