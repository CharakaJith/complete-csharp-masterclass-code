namespace Section02
{
    static class IncrementAndDecrement
    {
        public static void Example()
        {
            // ----- increment -----
            // pre-increment
            int x = 5;
            int y = ++x;

            Console.WriteLine("pre-increment");
            Console.WriteLine($"x : {x}");
            Console.WriteLine($"y : {y}");

            // post-increment
            int a = 5;
            int b = a++;

            Console.WriteLine("\npost-increment");
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");

            // ----- decrement -----
            // pre-decrement
            int c = 5;
            int d = --c;

            Console.WriteLine("\npre-decrement");
            Console.WriteLine($"c : {c}");
            Console.WriteLine($"d : {d}");

            // post-decrement
            int e = 5;
            int f = e--;

            Console.WriteLine("\npost-decrement");
            Console.WriteLine($"e : {e}");
            Console.WriteLine($"f : {f}");
        }
    }
}