using System;

namespace eMenka.API.Models.FuelCardModels.ReturnModels
{
    public class DriverReturnModel
    {
        public int Id { get; set; }
        public PersonReturnModel Person { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}