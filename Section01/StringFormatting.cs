namespace Section01
{
    static class StringFormatting
    {
        public static void Example()
        {
            // string interpolation
            string name = "Alice";
            string age = "20";

            Console.WriteLine($"{name} is {age} years old.");

            // string concatenation
            Console.WriteLine("\n" + name + " is " + age + " years old.");

            // string formatting
            Console.WriteLine(string.Format("\n{0} is {1} years old. {2} is an extra value.", name, age, "This"));
        }
    }
}