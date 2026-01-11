namespace Section01
{
    static class AdditionCalculator
    {
        public static void Example()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = Add(num1, num2);

            Console.WriteLine($"\n{num1} + {num2} = {sum}");
        }

        private static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}