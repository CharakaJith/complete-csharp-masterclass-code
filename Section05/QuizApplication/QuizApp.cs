namespace Section05.QuizApplication
{
    public class QuizApp()
    {
        private Question[]? Questions;
        private int CorrectCount = 0;

        public void StartGame()
        {
            // setup the questtions
            this.SetupQuestion();

            Console.WriteLine("---------- Quiz App ----------\n");

            // display questions
            foreach (Question question in Questions)
            {
                Console.WriteLine(question.QuestionText);

                // display answers
                for (int i = 0; i < question.Answers?.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Answers[i]}");
                }

                // get user input
                int input = GetUserInput();

                if (question.IsCorrectAnswer(input))
                {
                    CorrectCount++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine($"Incorrect! Correct answer is {question?.Answers[question.CorrectAnswerIndex - 1]}\n");
                }
            }

            Console.WriteLine($"your score: {CorrectCount}/5");
        }

        public void SetupQuestion()
        {
            Question q1 = new Question(
                "What is the capital of Australia?",
                ["Sydney", "Canberra", "Melbourne", "Brisbane"],
                2
            );
            Question q2 = new Question(
                "Which element has the chemical symbol ‘O’?",
                ["Oxygen", "Gold", "Osmium", "Iron"],
                1
            );
            Question q3 = new Question(
                "Who wrote Romeo and Juliet?",
                ["Charles Dickens", "Mark Twain", "Jane Austen", "William Shakespeare"],
                4
            );
            Question q4 = new Question(
                "What is the largest planet in our solar system?",
                ["Earth", "Jupiter", "Saturn", "Mars"],
                2
            );
            Question q5 = new Question(
                "Which programming language is primarily used for web development?",
                ["Python", "C++", "JavaScript", "Java"],
                3
            );

            this.Questions = [q1, q2, q3, q4, q5];
        }

        public int GetUserInput()
        {
            int ans;
            while (true)
            {
                Console.Write("answer: ");
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out ans) || ans < 1 || ans > 4)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 4!\n");
                    continue;
                }

                break;
            }

            return ans;
        }

    }
}