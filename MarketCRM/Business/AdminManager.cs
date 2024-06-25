namespace MarketCRM.Business
{
    internal class AdminManager : UserManager
    {

        
        public void AddSeller(Seller seller, List<Seller> sellers)
        {
            Console.WriteLine($"{seller.FullName} has been added succesfully");
            sellers.Add(seller);
        }
        public void AddKassir(Kassir kassir, List<Kassir> kassirs)
        {
            Console.WriteLine($"{kassir.FullName}  has been added succesfully");
            kassirs.Add(kassir);
        }
    }
}
