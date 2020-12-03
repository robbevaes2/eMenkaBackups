﻿using System;
using System.ComponentModel.DataAnnotations;
using eMenka.Domain.Classes;

namespace eMenka.API.Models.FuelCardModels
{
    public class FuelCardModel : IModelBase
    {
        [Required] public int? DriverId { get; set; }
        [Required] public int? VehicleId { get; set; }
        public Company Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime? BlockingDate { get; set; }
        public string BlockingReason { get; set; }
        public string PinCode { get; set; }
        public string Number { get; set; }
        public int Id { get; set; }
    }
}