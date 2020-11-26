namespace eMenka.API.Models.VehicleModels.ReturnModels
{
    public class SerieReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandReturnModel Brand { get; set; }
    }
}