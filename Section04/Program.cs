namespace Section04
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 94. Void method without parameters
            // VoidMethod.Example();
            // VoidMethod.SayHello("Jane");
            // VoidMethod.Add(10, 13);

            // 96. Methods with a return
            // int sum = MethodWithReturn.Add(10, 13);
            // Console.WriteLine($"\n{sum}");

            // 97. Variable and parameter scope
            int sum = VariableAndParameterScope.Add(10, 10);
            Console.WriteLine($"{sum}");

            int subs = VariableAndParameterScope.Subtract(10, 5);
            Console.WriteLine($"{subs}");
        }
    }
}