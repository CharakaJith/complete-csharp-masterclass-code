namespace Section01
{
    static class ImplicitConversion
    {
        public static void Example()
        {
            // int -> double
            int number = 13;
            double myNumber = number;

            Console.WriteLine($"int number: {number}");
            Console.WriteLine($"double number: {myNumber}");

            // float -> double
            float myFloat = 123.456f;
            double myDouble = myFloat;

            Console.WriteLine($"\nfloat number: {myFloat}");
            Console.WriteLine($"double number: {myDouble}");
        }
    }
}