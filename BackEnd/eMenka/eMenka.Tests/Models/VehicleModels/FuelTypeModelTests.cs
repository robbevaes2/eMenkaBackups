using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Models.VehicleModels;
using NUnit.Framework;

namespace eMenka.Tests.Models.VehicleModels
{
    [TestFixture]
    public class FuelTypeModelTests
    {
        [Test]
        public void AllGettersAndSettersFromPropertiesWork()
        {
            string name = "name";
            string code = "code";

            var sut = new FuelTypeModel()
            {
                Name = name,
                Code = code
            };

            Assert.That(sut.Name, Is.EqualTo(name));
            Assert.That(sut.Code, Is.EqualTo(code));
        }
    }
}
