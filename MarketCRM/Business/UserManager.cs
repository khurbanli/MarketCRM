using MarketCRM.Concrete;

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
                if(user != null)
                users.Add(user);
            }
        }

        public UserManager(int iD, string fullName, short age, string number, string email, string password, string role)
            : base(iD, fullName, age, number, email, password, role)
        {
        }

    }
}
