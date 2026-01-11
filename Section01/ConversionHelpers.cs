namespace Section01
{
    static class ConversionHelpers
    {
        public static void Example()
        {
            // Parse
            string intStr = "12345";
            int number = int.Parse(intStr);

            Console.WriteLine($"string number: {intStr}");
            Console.WriteLine($"int number: {number}");

            // TryParse
            string validIntStr = "67890";
            string invalidIntStr = "12345abc";

            int num1;
            int num2;
            bool isValid = int.TryParse(validIntStr, out num1);
            bool isValid2 = int.TryParse(invalidIntStr, out num2);

            Console.WriteLine($"\nvalid string output: {num1} | success: {isValid}");
            Console.WriteLine($"invalid string output: {num2} | success: {isValid2}");

            // Convert
            string boolStr = "true";
            bool myBool = Convert.ToBoolean(boolStr);

            Console.WriteLine($"\nstring boolean: {boolStr}");
            Console.WriteLine($"bool boolean: {myBool}");
        }    
    }
}