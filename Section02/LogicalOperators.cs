namespace Section02
{
    static class LogicalOperators
    {
        public static void Example()
        {
            // logical operators
            // && AND
            // || OR
            // !  NOT

            bool isRainy = true;
            bool hasUmbrella = false;

            if (isRainy && hasUmbrella)
            {
                Console.WriteLine("Its raining today! But Im okay!");
            }
            else if (isRainy && !hasUmbrella)
            {
                Console.WriteLine("Its raining today! Im fucked!");
            }
            else
            {
                Console.WriteLine("Its sunny today!");
            }            
        }
    }
}