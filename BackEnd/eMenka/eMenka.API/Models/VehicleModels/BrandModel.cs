using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class BrandModel
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }
        public int[] InteriorColorIds { get; set; }
        public int[] ExteriorColorIds { get; set; }
    }
}