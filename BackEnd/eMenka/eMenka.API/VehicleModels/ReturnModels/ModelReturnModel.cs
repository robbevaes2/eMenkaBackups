namespace eMenka.API.VehicleModels.ReturnModels
{
    public class ModelReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandReturnModel BrandReturn { get; set; }
    }
}
