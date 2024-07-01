using MarketCRM.Entity;

namespace MarketCRM
{
    internal class Kassir : User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void ProcessTransaction()
        {
            Console.WriteLine("Processing transaction...");
        }
        public Kassir(int iD, string fullName, short age, string number, string email, string password, string role) 
            : base(iD, fullName, age, number, email, password, role)
        {
        }
    }
}
