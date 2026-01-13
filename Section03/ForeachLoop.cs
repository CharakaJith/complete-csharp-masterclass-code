namespace Section03
{
    static class ForeachLoop
    {
        public static void Example()
        {
            string[] weekdays = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            foreach(string weekday in weekdays)
            {
                Console.WriteLine($"today is {weekday}");

                Thread.Sleep(1000);
            }

            Console.WriteLine("\nWeek completed!");
        }
    }
}