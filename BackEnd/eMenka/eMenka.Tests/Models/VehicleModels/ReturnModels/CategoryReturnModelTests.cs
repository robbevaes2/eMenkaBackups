using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Models.VehicleModels.ReturnModels;
using NUnit.Framework;

namespace eMenka.Tests.Models.VehicleModels.ReturnModels
{
    [TestFixture]
    public class CategoryReturnModelTests
    {
        [Test]
        public void AllGettersAndSettersFromPropertiesWork()
        {
            string name = "name";
            int id = 1;

            var sut = new CategoryReturnModel()
            {
                Name = name,
                Id = id
            };

            Assert.That(sut.Name, Is.EqualTo(name));
            Assert.That(sut.Id, Is.EqualTo(id));
        }
    }
}
