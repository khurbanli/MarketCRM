using MarketCRM.Entity;

namespace MarketCRM.Business
{
    internal class CategoriyaManager : Categoriya
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
                if (category != null) 
                categories.Add(category);
            }
        }

        public CategoriyaManager(int id, string name) 
            : base(id, name)
        {
        }
    }
}
