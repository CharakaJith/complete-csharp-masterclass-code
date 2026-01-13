namespace Section03
{
    static class AverageCalculator
    {
        public static void Example()
        {
            double average = 0;
            int counter = 0;
            double totalScore = 0;
            bool shouldContinue = true;

            Console.WriteLine("----- average calculator -----");
            Console.WriteLine("Enter the score to continue or 'n' to stop");
            do
            {
                Console.Write("score: ");
                string? input = Console.ReadLine()?.Trim();

                if (string.Equals(input?.ToUpper(), "N"))
                {
                    shouldContinue = false;
                }

                bool isValidInput = double.TryParse(input, out double score);
                if (isValidInput)
                {
                    counter++;

                    totalScore += score;
                    average = totalScore / counter;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input!\n");   
                }
            }
            while (shouldContinue);

            Console.WriteLine($"\n Your average: ({totalScore}/{counter}) = {average:F2}");
        }
    }
}