namespace Section05.Parameters
{
    public static class Increment
    {
        public static void Increse(int x)
        {
            x += 1;
            Console.WriteLine($"Increase method: {x - 1} -> {x}");
        } 

        public static void IncreaseByReference(ref int x)
        {
            x += 1;
            Console.WriteLine($"IncreaseByReference method: {x - 1} -> {x}");
        }
    }
}