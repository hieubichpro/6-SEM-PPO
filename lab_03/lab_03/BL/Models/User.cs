namespace lab_03.BL.Models
{
    public class User
    {
        private int id;
        private string login;
        private string password;
        private string role;
        private string name;

        public User(string login, string password, string role, string name, int id = 1)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.role = role;
            this.name = name;
        }
        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Name { get => name; set => name = value; }

        public bool checkPassword(string password)
        {
            return this.password == password;
        }
    }
}
