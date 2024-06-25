using MarketCRM.Entity;

namespace MarketCRM
{
    internal class Seller : User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Seller(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
