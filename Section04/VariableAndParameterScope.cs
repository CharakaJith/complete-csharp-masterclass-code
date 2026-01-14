namespace Section04
{
    static class VariableAndParameterScope
    {
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        public static int Subtract(int num1, int num2)
        {
            int result1 = num1 - num2; // this is a complete different result from Add()

            return result1;
        }
    }
}