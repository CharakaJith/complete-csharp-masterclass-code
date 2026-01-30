namespace Section05.Properties
{
    public class Book
    {
        private static int _id { get; set; } = 0; // static field to make this a shared counter
        private int Id { get; } // read only property
        private string Name { get; set; }
        private string Author { get; set; }

        public Book(string n, string a)
        {
            _id += 1;
            Id = _id;
            Name = n;
            Author = a;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{Id}. {Name} by {Author}");
        }

        public void UpdateBook(string n, string a)
        {
            Name = n;
            Author = a;
        }

        // public void UpdateId(int i)
        // {
        //     Id = i; // not allowed because Id is readonly
        // }

        public void UpdateName(string n)
        {
            Name = n;
        }

        public void UpdateAuthor(string a)
        {
            Author = a;
        }
    }
}