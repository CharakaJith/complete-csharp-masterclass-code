namespace Section04
{
    static class MethodWithReturn
    {
        public static int Add(int num1, int num2)
        {
            Console.Write("Add(int num1, int num2) method in the MethodWithReturn class called");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            Console.Write($"\n{num1} + {num2} is: ");

            return num1 + num2;
        }
    }
}