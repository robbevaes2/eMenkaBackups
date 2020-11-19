﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers
{
    public static class FuelCardMappers
    {
        public static FuelCardReturnModel MapFuelCardEntity(FuelCard fuelCard)
        {
            return new FuelCardReturnModel
            {
                Driver = MapDriverEntity(fuelCard.Driver),
                EndDate = fuelCard.EndDate,
                StartDate = fuelCard.StartDate,
                Id = fuelCard.Id,
                BlockingDate = fuelCard.BlockingDate,
                BlockingReason = fuelCard.BlockingReason,
                IsBlocked = fuelCard.IsBlocked,
                PinCode = fuelCard.PinCode
            };
        }
        public static FuelCard MapFuelCardModel(FuelCardModel fuelCardModel)
        {
            return new FuelCard
            {
                DriverId = (int)fuelCardModel.DriverId,
                EndDate = fuelCardModel.EndDate,
                Id = fuelCardModel.Id,
                StartDate = fuelCardModel.StartDate,
                BlockingDate = fuelCardModel.BlockingDate,
                BlockingReason = fuelCardModel.BlockingReason,
                IsBlocked = fuelCardModel.IsBlocked,
                PinCode = fuelCardModel.PinCode
            };
        }
        public static DriverReturnModel MapDriverEntity(Driver driver)
        {
            return new DriverReturnModel
            {
                EndDate = driver.EndDate,
                StartDate = driver.StartDate,
                Id = driver.Id,
                Person = MapPersonEntity(driver.Person)
            };
        }
        public static Driver MapDriverModel(DriverModel driverModel)
        {
            return new Driver
            {
                Id = driverModel.Id,
                EndDate = driverModel.EndDate,
                PersonId = (int)driverModel.PersonId,
                StartDate = driverModel.StartDate
            };
        }
        public static PersonReturnModel MapPersonEntity(Person person)
        {
            return new PersonReturnModel
            {
                Title = person.Title,
                BirthDate = person.BirthDate,
                StartDateDriversLicense = person.StartDateDriversLicense,
                Picture = person.Picture,
                Lastname = person.Lastname,
                Language = person.Language,
                Id = person.Id,
                Gender = person.Gender,
                Firstname = person.Firstname,
                EndDateDriversLicense = person.EndDateDriversLicense,
                DriversLicenseNumber = person.DriversLicenseNumber,
                DriversLicenseType = person.DriversLicenseType
            };
        }
        public static Person MapPersonModel(PersonModel personModel)
        {
            return new Person
            {
                BirthDate = personModel.BirthDate,
                DriversLicenseNumber = personModel.DriversLicenseNumber,
                DriversLicenseType = personModel.DriversLicenseType,
                EndDateDriversLicense = personModel.EndDateDriversLicense,
                Firstname = personModel.Firstname,
                Gender = personModel.Gender,
                Id = personModel.Id,
                Language = personModel.Language,
                Lastname = personModel.Lastname,
                Picture = personModel.Picture,
                StartDateDriversLicense = personModel.StartDateDriversLicense,
                Title = personModel.Title
            };
        }
    }
}
