namespace Section05.Properties
{
    public class Admin
    {
        private string? _password; // field where the value is stored

        public string Email { get; set; }
        public string Password
        {
            set { _password = value; } // write only property
        }

        public Admin(string m, string p)
        {
            Email = m;
            Password = p;
        }
    }
}