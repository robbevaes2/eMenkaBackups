using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class EngineTypeModel
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        [Required] public int? BrandId { get; set; }
    }
}