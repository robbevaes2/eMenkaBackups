using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Models.VehicleModels.ReturnModels;
using NUnit.Framework;

namespace eMenka.Tests.Models.VehicleModels.ReturnModels
{
    [TestFixture]
    public class CountryReturnModelTests
    {
        [Test]
        public void AllGettersAndSettersFromPropertiesWork()
        {
            string name = "name";
            string code = "code";
            string nationality = "BE";
            bool pod = true;
            bool isActive = true;
            int id = 1;

            var sut = new CountryReturnModel()
            {
                Name = name,
                Code = code,
                IsActive = isActive,
                Id = id,
                Nationality = nationality,
                POD = pod
            };

            Assert.That(sut.Name, Is.EqualTo(name));
            Assert.That(sut.Code, Is.EqualTo(code));
            Assert.That(sut.IsActive, Is.EqualTo(isActive));
            Assert.That(sut.Id, Is.EqualTo(id));
            Assert.That(sut.Nationality, Is.EqualTo(nationality));
            Assert.That(sut.POD, Is.EqualTo(pod));
        }
    }
}
