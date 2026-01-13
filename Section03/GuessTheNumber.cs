namespace Section03
{
    static class GuessTheNumber
    {
        public static void Example()
        {
            // generate a random number between 1-20
            Random random = new Random();
            int randomInt = random.Next(1, 21);

            Console.WriteLine("Guess the number between 1 - 20");            

            int tries = 0;
            while (true)
            {
                tries++;

                Console.Write("\nyour guess: ");
                string? numStr = Console.ReadLine();

                bool isValidNum = int.TryParse(numStr, out int num);
                if (isValidNum)
                {
                    if (num == randomInt)
                    {
                        Console.WriteLine("Correct!");
                        break;
                    }
                    else if (num < randomInt)
                    {
                        Console.WriteLine("Higher!");
                    }
                    else if (num > randomInt)
                    {
                        Console.WriteLine("Lower!");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid number {numStr}");
                }                
            }    

            Console.WriteLine($"\nYou guessed the correct number in {tries} tries!");        
        }
    }
}