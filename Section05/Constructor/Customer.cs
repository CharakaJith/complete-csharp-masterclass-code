namespace Section05.Constructor
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }

        // default constructor
        public Customer()
        {
            Name = "N/A";
            City = "N/A";
            Mobile = "N/A";
        }

        // parameterized constructor
        public Customer(string name)
        {
            Name = name;
            City = "N/A";
            Mobile = "N/A";
        }

        // parameterized constructor with multiple parameters
        public Customer(string name, string city, string mobile)
        {
            Name = name;
            City = city;
            Mobile = mobile;
        }

        public void GetDetails()
        {
            Console.WriteLine($"{Name} : {City} : {Mobile}");
        }
    }
}