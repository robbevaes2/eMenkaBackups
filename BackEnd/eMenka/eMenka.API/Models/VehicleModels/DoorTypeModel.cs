using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class DoorTypeModel : IModelBase
    {
        [Required] public string Name { get; set; }
        public int Id { get; set; }
    }
}