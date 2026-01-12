namespace Section02
{
    static class ConditionalStatements
    {
        public static void Example()
        {
            bool isRainy = true;
            bool hasUmbrella = false;

            if (isRainy)
            {
                Console.WriteLine("Its raining today!");
            }
            else if (hasUmbrella)
            {
                Console.WriteLine("I have my umbrella!");
            }
            else
            {
                Console.WriteLine("Its sunny today!");
            }            
        }
    }
}