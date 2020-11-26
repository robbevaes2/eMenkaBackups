using System;

namespace eMenka.API.Models.RecordModels.ReturnModels
{
    public class CostAllocationReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}