﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eMenka.Domain.Classes
{
    public class CostAllocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
