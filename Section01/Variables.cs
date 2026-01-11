namespace Section01 
{
    static class Variables
    {
        public static void Example()
        {
            // value type
            int age = 30;
            int year = 2026;

            // reference type
            string name = "Alice Smith";

            Console.WriteLine($"name: {name} | age: {age} | year: {year}");

            Console.WriteLine("");

            // define a variable
            string petname;

            // initialize the variable
            petname = "Buddy";
            Console.WriteLine($"petname: {petname}");

            // update the variable
            petname = "Max";
            Console.WriteLine($"petname: {petname}");
        }
    }
}