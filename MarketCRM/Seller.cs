using MarketCRM.Entity;

namespace MarketCRM
{
    internal class Seller : User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void SellProduct(Product product)
        {
            Console.WriteLine($"Selling product: {product.ProductName}");
        }
        public Seller(int iD, string fullName, short age, string number, string email, string password, string role) 
            : base(iD, fullName, age, number, email, password, role)
        {
        }
    }
}
