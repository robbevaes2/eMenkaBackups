namespace eMenka.Domain.Classes
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Types { get; set; }
        public bool Active { get; set; }
        public bool Internal { get; set; }

    }
}
