using System;
using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.RecordModels
{
    public class CorporationModel : IModelBase
    {
        [Required] public string Name { get; set; }

        public string Abbreviation { get; set; }

        [Required] public int? CompanyId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Id { get; set; }
    }
}