using MarketCRM.Entity;

namespace MarketCRM.Business
{
    internal class CategoriyaManager
    {
        private List<Categoriya> categories = new List<Categoriya>();

        public void AddCategory(Categoriya category)
        {
            categories.Add(category);
        }

        public void ListCategories()
        {
            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }
        }
    }
}
