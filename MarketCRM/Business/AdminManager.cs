namespace MarketCRM.Business
{
    internal class AdminManager : UserManager
    {
        public int ID { get; set; }
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

        public AdminManager(int iD, string fullName, short age, string number, string email, string password, string role)
           : base(iD, fullName, age, number, email, password, role)
        {
        }
    }
}
