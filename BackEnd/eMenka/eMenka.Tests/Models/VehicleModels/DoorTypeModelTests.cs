using System;
using System.Collections.Generic;
using System.Text;
using eMenka.API.Models.VehicleModels;
using NUnit.Framework;

namespace eMenka.Tests.Models.VehicleModels
{
    [TestFixture]
    public class DoorTypeModelTests
    {
        [Test]
        public void PropertyNameGetsAndSetsProperty()
        {
            string name = "name";

            var sut = new DoorTypeModel()
            {
                Name = name
            };

            Assert.That(sut.Name, Is.EqualTo(name));
        }
    }
}
