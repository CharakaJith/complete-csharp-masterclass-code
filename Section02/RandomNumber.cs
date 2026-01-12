namespace Section02
{
    static class RandomNumber
    {
        public static void Example()
        {
            // generate a random number between 1-10
            Random random = new Random();
            int randomNum = random.Next(1, 11);

            Console.Write("Guess the number: ");
            string? intStr = Console.ReadLine();

            bool isValidNum = int.TryParse(intStr?.Trim(), out int num);
            if (isValidNum)
            {
                if (num == randomNum)
                {
                    Console.WriteLine("\nCorrect!");
                }
                else
                {
                    Console.WriteLine($"\nIncorrect! Random number is {randomNum}!");
                }
            }
            else
            {
                Console.WriteLine($"\nInvalid input {intStr}");
            }
        }
    }
}