namespace Section03
{
    static class CountDown
    {
        public static void Example()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("\nBell ringing.....");
        }
    }
}