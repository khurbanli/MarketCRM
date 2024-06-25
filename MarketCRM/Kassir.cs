using MarketCRM.Entity;

namespace MarketCRM
{
    internal class Kassir : User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Kassir(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
