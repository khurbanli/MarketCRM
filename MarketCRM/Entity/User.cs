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
    }
}
