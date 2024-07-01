using MarketCRM.Concrete;

namespace MarketCRM
{
    internal class Admin : User
    {
        public int ID { get; set; }
        public string AdimUser { get; set; }

        public void ManageUsers()
        {
            Console.WriteLine("Managing users...");
        }

        public Admin(int iD, string fullName, short age, string number, string email, string password, string role) 
            : base(iD, fullName, age, number, email, password, role)
        {
        }
    }
}
