﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.Models.FuelCardModels
{
    public class FuelCardModel
    {
        public int Id { get; set; }
        [Required]
        public int? DriverId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime? BlockingDate { get; set; }
        public string BlockingReason { get; set; }
        public string PinCode { get; set; }
        public string Number { get; set; }
    }
}