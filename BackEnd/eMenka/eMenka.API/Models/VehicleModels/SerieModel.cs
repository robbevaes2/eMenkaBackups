using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class SerieModel : IModelBase
    {
        [Required] public string Name { get; set; }

        [Required] public int? BrandId { get; set; }
        public int Id { get; set; }
    }
}