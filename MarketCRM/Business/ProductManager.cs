﻿using MarketCRM.Concrete;

namespace MarketCRM.Business
{
    internal class ProductManager : Product
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
                if (item.Id == products.id)
                {
                    products.Add(item);
                }
            }
        }
        public ProductManager(int id, string name, double price, string category) 
            : base(id, name, price, category)
        {
           
        }
    }
}
