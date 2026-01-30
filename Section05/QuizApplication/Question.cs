namespace Section05.QuizApplication
{
    public class Question
    {
        public string? QuestionText { get; set; }
        public string[]? Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string question, string[] answers, int index)
        {
            QuestionText = question;
            Answers = answers;
            CorrectAnswerIndex = index;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}