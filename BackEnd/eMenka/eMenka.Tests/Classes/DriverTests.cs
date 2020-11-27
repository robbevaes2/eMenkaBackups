using System;
using System.Collections.Generic;
using System.Text;
using eMenka.Domain.Classes;
using NUnit.Framework;

namespace eMenka.Tests.Classes
{
    [TestFixture]
    public class DriverTests
    {
        private Driver _sut;

        [SetUp]
        public void Init()
        {
            _sut = new Driver();
        }

        [Test]
        public void DriverFuelCardIdPropertyGetsAndSetsFuelCardId()
        {
            var fuelCardId = 1;

            _sut.FuelCardId = fuelCardId;

            Assert.That(_sut.FuelCardId, Is.EqualTo(fuelCardId));
        }

        [Test]
        public void DriverFuelCardPropertyGetsAndSetsFuelCard()
        {
            var fuelCard = new FuelCard();

            _sut.FuelCard = fuelCard;

            Assert.That(_sut.FuelCard, Is.EqualTo(fuelCard));
        }
    }
}
