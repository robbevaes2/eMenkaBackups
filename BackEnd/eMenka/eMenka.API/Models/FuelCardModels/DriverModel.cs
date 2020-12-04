using System;
using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.FuelCardModels
{
    public class DriverModel : IModelBase
    {
        [Required] public int? PersonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Id { get; set; }
    }
}