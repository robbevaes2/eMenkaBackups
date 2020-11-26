using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class BrandModel : IModelBase
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }
    }
}