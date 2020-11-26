using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class CategoryModel : IModelBase
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }
    }
}