using System;

namespace eMenka.API.Models.RecordModels.ReturnModels
{
    public class CorporationReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public CompanyReturnModel Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}