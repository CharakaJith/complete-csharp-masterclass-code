namespace Section02
{
    static class ClubProgram
    {
        public static void Example()
        {
            Console.Write("Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you have an adult with you (Y/N): ");
            string? hasAdult = Console.ReadLine();

            string message;
            if (age <= 0 || age > 100)
            {
                message = "Please get born first!";
            }
            else if (age >= 18)
            {
                message = "Please enter the club!";
            }
            else if (age >= 13 && (hasAdult == "Y" || hasAdult == "y"))
            {
                message = "Please enter the junior club!";
            }
            else
            {
                message = "Please go home!";
            }

            Console.WriteLine($"\n{message}");
        }
    }
}