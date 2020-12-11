using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Models.VehicleModels.ReturnModels;
using NUnit.Framework;

namespace eMenka.Tests.Models.VehicleModels.ReturnModels
{
    [TestFixture]
    public class InteriorColorReturnModelTests
    {
        [Test]
        public void AllGettersAndSettersFromPropertiesWork()
        {
            string name = "name";
            int id = 1;
            string code = "code";

            var sut = new InteriorColorReturnModel()
            {
                Name = name,
                Id = id,
                Code = code
            };

            Assert.That(sut.Name, Is.EqualTo(name));
            Assert.That(sut.Id, Is.EqualTo(id));
            Assert.That(sut.Code, Is.EqualTo(code));
        }
    }
}
