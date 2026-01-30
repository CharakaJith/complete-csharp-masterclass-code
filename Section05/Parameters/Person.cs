namespace Section05.Parameters
{
    public class Person
    {
        private string Name { get; set; }

        public Person()
        {
            Name = "N/A";
        }

        public Person(string n)
        {
            Name = n;
        }

        public void SayHello(string greet = "Hello")
        {
            Console.WriteLine($"{greet}, {Name}!");
        }
    }
}