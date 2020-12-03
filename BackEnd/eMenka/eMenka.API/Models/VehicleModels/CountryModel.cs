using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.VehicleModels
{
    public class CountryModel : IModelBase
    {
        [Required] public string Name { get; set; }

        public string Code { get; set; }
        public string Nationality { get; set; }
        public bool POD { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }
    }
}