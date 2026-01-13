namespace Section03
{
    static class WhileLoop
    {
        public static void Example()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"counter is {counter}");

                counter++;
            }
        }
    }
}