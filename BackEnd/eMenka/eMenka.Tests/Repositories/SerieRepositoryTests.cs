﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMenka.Data.Repositories;
using eMenka.Domain.Classes;
using eMenka.Tests.Utils;
using NUnit.Framework;

namespace eMenka.Tests.Repositories
{
    [TestFixture]
    public class SerieRepositoryTests
    {
        private SerieRepository _sut;

        [OneTimeSetUp]
        public void Init()
        {
            EfenkaContextTestFactory.Create();
            _sut = new SerieRepository(EfenkaContextTestFactory.EfenkaContext);
        }

        [Test]
        public void GetAllIncludesAllRelationsOfSerie()
        {
            var brand = new Brand();

            var serie = new Series()
            {
                Brand = brand
            };

            _sut.Add(serie);

            var series = _sut.GetAll();

            Assert.That(series, Is.Not.Null);

            var serieFromDatabase = series.FirstOrDefault(s => s.Id == serie.Id);

            Assert.That(serieFromDatabase.Brand, Is.EqualTo(brand));
        }

        [Test]
        public void GetByIdIncludesAllRelationsOfSerie()
        {
            var brand = new Brand();

            var series = new Series()
            {
                Brand = brand
            };

            _sut.Add(series);

            var seriesFromDatabase = _sut.GetById(series.Id);

            Assert.That(seriesFromDatabase.Brand, Is.EqualTo(brand));
        }

        [Test]
        public void FindIncludesAllRelationsOfSerie()
        {
            var brand = new Brand();

            var series = new Series()
            {
                Brand = brand
            };

            _sut.Add(series);

            var seriesFromDatabase = _sut.Find(s => s.Id == series.Id).FirstOrDefault();

            Assert.That(seriesFromDatabase.Brand, Is.EqualTo(brand));
        }
    }
}
