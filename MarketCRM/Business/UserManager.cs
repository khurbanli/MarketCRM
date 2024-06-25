using MarketCRM.Entity;

namespace MarketCRM.Business
{
    internal class UserManager : User
    {
        public List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void ListUsers()
        {
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }
        }

    }
}
