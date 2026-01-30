namespace Section05.Methods
{
    public class User
    {
        // private make sure these fields cannot be accessed outside the class
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        public User(string name, string mail, string pwd)
        {
            Name = name;
            Email = mail;
            Password = pwd;
        }

        public void Login(string mail, string pwd)
        {
            if (string.Equals(Email, mail) && string.Equals(Password, pwd))
                Console.WriteLine($"User {Name} logged in!");
            else
                Console.WriteLine("Invalid login credentials!");
        }

        public void UpdatePassword(string currentPwd, string newPwd)
        {
            if (string.Equals(Password, currentPwd))
            {
                Password = newPwd;
                Console.WriteLine("Password updated successfully!");
            }                
            else
                Console.WriteLine("Current password is worng!");
        }
    }
}