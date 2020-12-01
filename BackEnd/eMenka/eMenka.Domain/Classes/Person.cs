﻿using System;
using eMenka.Domain.Enums;

namespace eMenka.Domain.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? BirthDate { get; set; }
        public Language Language { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string DriversLicenseType { get; set; }
        public DateTime? StartDateDriversLicense { get; set; }
        public DateTime? EndDateDriversLicense { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public byte[] Picture { get; set; }
    }
}