using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class BrandModel : IModelBase
    {
        [Required] public string Name { get; set; }
        public int[] InteriorColorIds { get; set; }
        public int[] ExteriorColorIds { get; set; }
        public int Id { get; set; }
    }
}