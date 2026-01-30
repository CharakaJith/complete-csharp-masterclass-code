namespace Section05.Static
{
    public class Game
    {
        public static int NumOfGames { get; set; } = 0;
        public string? Title { get; set; }
        public string Genre { get; set; }
    
        public Game(string t, string g)
        {
            NumOfGames += 1;
            Title = t;
            Genre = g;
        }

        public void PrintGame()
        {
            Console.WriteLine($"{Title} - {Genre}");
        }
    }
}