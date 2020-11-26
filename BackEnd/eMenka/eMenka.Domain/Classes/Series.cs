namespace eMenka.Domain.Classes
{
    public class Series
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}