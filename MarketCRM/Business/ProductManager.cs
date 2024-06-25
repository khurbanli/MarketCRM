using MarketCRM.Entity;

namespace MarketCRM.Business
{
    internal class ProductManager 
    {
       

        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ListProducts()
        {
            foreach (Product item in products)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
