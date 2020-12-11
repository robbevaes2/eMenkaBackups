using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Models.VehicleModels;
using NUnit.Framework;

namespace eMenka.Tests.Models.VehicleModels
{
    [TestFixture]
    public class VehicleModelTests
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

            var sut = new VehicleModel()
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
                CountryId = countryId,
                BuildYear = buildYear,
                Kilometers = kilometers,
                RegistrationDate = registrationDate,
                ExteriorColorId = exteriorColor,
                InteriorColorId = interiorColor
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
            Assert.That(sut.CountryId, Is.EqualTo(countryId));
            Assert.That(sut.BuildYear, Is.EqualTo(buildYear));
            Assert.That(sut.Kilometers, Is.EqualTo(kilometers));
            Assert.That(sut.RegistrationDate, Is.EqualTo(registrationDate));
            Assert.That(sut.ExteriorColorId, Is.EqualTo(exteriorColor));
            Assert.That(sut.InteriorColorId, Is.EqualTo(interiorColor));
        }
    }
}
