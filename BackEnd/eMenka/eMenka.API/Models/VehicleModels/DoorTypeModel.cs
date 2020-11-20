using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class DoorTypeModel
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }
    }
}