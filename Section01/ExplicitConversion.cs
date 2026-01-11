namespace Section01
{
    static class ExplicitConversion
    {
        public static void Example()
        {
            // double -> int
            double myDouble = 9.78;
            int myInt = (int)myDouble;

            Console.WriteLine($"double number: {myDouble}");
            Console.WriteLine($"int number: {myInt}");

            // long -> int
            long myLong = 130123456789123456;
            int myInt2 = (int)myLong;

            Console.WriteLine($"\nlong number: {myLong}");
            Console.WriteLine($"int number: {myInt2}");

            // double -> float
            double anotherDouble = 19.99;
            float myFloat = (float)anotherDouble;

            Console.WriteLine($"\ndouble number: {anotherDouble}");
            Console.WriteLine($"float number: {myFloat}");
        }
    }
}
