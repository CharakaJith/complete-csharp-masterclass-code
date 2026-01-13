namespace Section03
{
    static class ControlStatements
    {
        public static void Example()
        {
            Console.WriteLine("----- break -----");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine($"i is {i}");
            }

            Console.WriteLine("\n----- continue -----");
            for (int i = 0; i < 10; i++)
            {
                if (i == 3 || i == 5)
                {
                    continue;
                }

                Console.WriteLine($"i is {i}");               
            }
        }
    }
}