namespace Section02
{
    static class TernaryOperator
    {
        public static void Example()
        {
            string name = "Jane";
            int age = 8;
            string message = age >= 18 ? "adult" : "minor";

            Console.WriteLine($"{name} is a {message}");
        }
    }
}