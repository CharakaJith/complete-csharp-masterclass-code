namespace Section03
{
    static class DoWhileLoop
    {
        public static void Example()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"counter is {counter}");

                counter++;
            }
            while (counter <= 10);
        }
    }
}