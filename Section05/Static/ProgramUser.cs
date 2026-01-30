namespace Section05.Static
{
    public static class ProgramUser
    {
        public static int Id { get; set; } = 0;
        public static string? Name { get; set; }
        public static string? Password { get; set; }

        public static void SetUser(string n, string p)
        {
            Id += 1;
            Name = n;
            Password = p;
        }

        public static void PrintUser()
        {
            Console.WriteLine($"{Id}. {Name} | {Password}");
        }
    }
}