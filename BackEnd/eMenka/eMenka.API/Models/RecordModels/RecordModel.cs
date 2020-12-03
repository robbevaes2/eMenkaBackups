using eMenka.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.RecordModels
{
    public class RecordModel : IModelBase
    {
        [Required] public int? FuelCardId { get; set; }

        [Required] public int? CorporationId { get; set; }

        [Required] public int? CostAllocationId { get; set; }

        public Term Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Usage Usage { get; set; }
        public int Id { get; set; }
    }
}