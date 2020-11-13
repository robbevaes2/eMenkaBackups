using System.Collections.Generic;

namespace eMenka.API.VehicleModels.ReturnModels
{
    public class BrandReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelReturnModel> Models { get; set; }
        public ICollection<SerieReturnModel> Series { get; set; }
        public ICollection<MotorTypeReturnModel> MotorTypes { get; set; }
        public ICollection<ExteriorColorModel> ExteriorColors { get; set; }
        public ICollection<InteriorColorModel> InteriorColors { get; set; }
    }
}
