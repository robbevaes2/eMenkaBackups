namespace eMenka.API.Models.VehicleModels.ReturnModels
{
    public class CountryReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Nationality { get; set; }
        public bool POD { get; set; }
        public bool IsActive { get; set; }
    }
}