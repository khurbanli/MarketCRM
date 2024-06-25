namespace MarketCRM.Entity
{
    internal class Categoriya
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Categoriya(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}