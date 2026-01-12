namespace Section02
{
    static class TryParse
    {
        public static void Example()
        {
            Console.Write("Enter a number: ");
            string? intStr = Console.ReadLine();

            int number;
            bool isValidNum = int.TryParse(intStr, out number);

            if (isValidNum)
            {
                Console.WriteLine($"\nYour number is {number}");
            }
            else
            {
                Console.WriteLine($"\nInvalid input {intStr}");
            }
        }
    }
}