namespace Section05.Constructor
{
    class Car
    {
        // member variables
        // private keyword hides them from other classes
        // readonly makes them only readable, cannot change the value
        private readonly string _type;
        private readonly string _brand;

        // constructor
        // called when an object is created from the class
        public Car()
        {
            _type = "Default";
            _brand = "No brand";

            PrintModel();
        }

        // parameterized constructore
        // called when an object is created from the class with a string passed
        public Car(string name, string brand)
        {
            _type = name;
            _brand = brand;

            PrintModel();
        }

        private void PrintModel()
        {
            Console.WriteLine($"Car object with name {_type}:{_brand} has been created!");
        }

        public void Run()
        {
            Console.WriteLine($"{_type}:{_brand} is running...");
        }
    }
}