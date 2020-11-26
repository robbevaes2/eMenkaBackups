﻿using eMenka.API.Models.VehicleModels.ReturnModels;
using System;
using eMenka.Domain.Classes;

namespace eMenka.API.Models.FuelCardModels.ReturnModels
{
    public class FuelCardReturnModel
    {
        public int Id { get; set; }
        public DriverReturnModel Driver { get; set; }
        public VehicleReturnModel Vehicle { get; set; }
        public Company Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime? BlockingDate { get; set; }
        public string BlockingReason { get; set; }
        public string PinCode { get; set; }
        public string Number { get; set; }
    }
}