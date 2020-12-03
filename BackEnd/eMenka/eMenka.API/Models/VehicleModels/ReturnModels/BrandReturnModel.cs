﻿using System.Collections.Generic;

namespace eMenka.API.Models.VehicleModels.ReturnModels
{
    public class BrandReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<InteriorColorReturnModel> InteriorColors { get; set; }
        public List<ExteriorColorReturnModel> ExteriorColors { get; set; }
    }
}