using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class FuelTypeModel
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        public string Code { get; set; }
    }
}