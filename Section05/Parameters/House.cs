namespace Section05.Parameters
{
    public class House
    {
        private string City {get; set; }
        private string Country {get; set; }

        public House(string city, string country)
        {
            City = city;
            Country = country;
        }

        public void PrintAddress()
        {
            Console.WriteLine($"{City} - {Country}");
        }
    }
}