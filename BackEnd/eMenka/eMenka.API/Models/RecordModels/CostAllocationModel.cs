using System;
using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.RecordModels
{
    public class CostAllocationModel
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        public string Abbreviation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}