namespace Section03
{
    static class RocketLanding
    {
        public static void Example()
        {
            Console.WriteLine("Rocket is landing in:");

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);

                Thread.Sleep(1000);
            }

            Console.WriteLine("\nRocket has landed successfully...");
        }
    }
}