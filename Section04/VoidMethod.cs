namespace Section04
{
    static class VoidMethod
    {
        public static void Example()
        {
            Console.Write("Example() method in the VoidMethod class called");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            Console.WriteLine("\nExample() is a method that returns nothing (void)");
        }

        public static void SayHello(string name)
        {
            Console.WriteLine($"\nHello, {name}!");

            Console.WriteLine("SayHello(string name) is a method that accepts a parameter and returns nothing (void)");
        }

        public static void Add(int num1, int num2)
        {
            int sum = num1 + num2;

            Console.WriteLine($"\n{num1} + {num2} = {sum}");
        }
    }
}