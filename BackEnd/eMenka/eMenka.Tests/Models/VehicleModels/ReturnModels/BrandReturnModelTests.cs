using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Models.VehicleModels.ReturnModels;
using NUnit.Framework;

namespace eMenka.Tests.Models.VehicleModels.ReturnModels
{
    [TestFixture]
    public class BrandReturnModelTests
    {
        [Test]
        public void AllGettersAndSettersFromPropertiesWork()
        {
            string name = "name";
            int id = 1;

            var sut = new BrandReturnModel()
            {
                Name = name,
                Id = id,
                ExteriorColors = null,
                InteriorColors = null
            };

            Assert.That(sut.Name, Is.EqualTo(name));
            Assert.That(sut.Id, Is.EqualTo(id));
            Assert.That(sut.ExteriorColors, Is.Null);
            Assert.That(sut.InteriorColors, Is.Null);
        }
    }
}
