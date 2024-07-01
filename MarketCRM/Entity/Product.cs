namespace MarketCRM.Entity
{
    internal class Product 
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCategory { get; set; }

        public Product(int id, string name, double price, string category)
        {
            Id = id;
            ProductName = name;
            ProductPrice = price;
            ProductCategory = category;
        }
    }
}
