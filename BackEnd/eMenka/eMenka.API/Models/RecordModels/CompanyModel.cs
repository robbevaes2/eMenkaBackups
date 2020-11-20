﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.Models.RecordModels
{
    public class CompanyModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public bool? IsInternal { get; set; }
        public bool? IsActive { get; set; }
        public string NonActiveRemark { get; set; }
        public string VAT { get; set; }
        public string AccountNumber { get; set; }
    }
}
