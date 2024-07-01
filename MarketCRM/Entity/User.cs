namespace MarketCRM.Entity
{
    internal class User 
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public short Age { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User(int iD, string fullName, short age, string number, string email, string password, string role)
        {
            ID = iD;
            FullName = fullName;
            Age = age;
            Number = number;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
