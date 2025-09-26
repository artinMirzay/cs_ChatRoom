namespace cs_ChatRoom
{
    public class User
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(string username, string password)
        {
            Id = _nextId++;
            Username = username;
            Password = password;
        }

        public static User CreateUserProfile()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            return new User(username, password);
        }
    }
}