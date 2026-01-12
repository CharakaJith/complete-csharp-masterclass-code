namespace Section02
{
    static class QuizApp
    {
        public static void Example()
        {
            string q1 = "Captial of Germany?";
            string a1 = "Berlin";
            
            string q2 = "2 + 2?";
            string a2 = "4";

            string q3 = "blue + yellow mix?";
            string a3 = "Green";

            int score = 0;
            Console.Write($"{q1} ");
            string? answer1 = Console.ReadLine();
            if (string.Equals(answer1?.Trim().ToUpper(), a1.ToUpper()))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong! Correct answer is {a1}");
            }

            Console.Write($"\n{q2} ");
            string? answer2 = Console.ReadLine();
            if (string.Equals(answer2?.Trim(), a2))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong! Correct answer is {a2}");
            }

            Console.Write($"\n{q3} ");
            string? answer3 = Console.ReadLine();
            if (string.Equals(answer3?.Trim().ToUpper(), a3.ToUpper()))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong! Correct answer is {a3.ToLower()}");
            }

            Console.WriteLine($"\nYour score is {score}/3");
            if (score == 3)
            {
                Console.WriteLine("Good job!");
            }
            else
            {
                Console.WriteLine("Keep learning!");
            }
        }
    }
}