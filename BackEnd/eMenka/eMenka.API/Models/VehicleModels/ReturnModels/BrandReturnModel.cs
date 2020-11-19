using System.Collections.Generic;

namespace eMenka.API.Models.VehicleModels.ReturnModels
{
    public class BrandReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelReturnModel> Models { get; set; }
        public ICollection<SerieReturnModel> Series { get; set; }
        public ICollection<EngineTypeReturnModel> EngineTypes { get; set; }
        public ICollection<ExteriorColorReturnModel> ExteriorColors { get; set; }
        public ICollection<InteriorColorReturnModel> InteriorColors { get; set; }
    }
}
