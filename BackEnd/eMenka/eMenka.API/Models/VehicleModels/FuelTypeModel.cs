using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class FuelTypeModel : IModelBase
    {
        [Required] public string Name { get; set; }

        public string Code { get; set; }
        public int Id { get; set; }
    }
}