namespace eMenka.API.Models.VehicleModels.ReturnModels
{
    public class ModelReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandReturnModel Brand { get; set; }
    }
}