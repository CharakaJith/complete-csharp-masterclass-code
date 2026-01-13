namespace Section03
{
    static class SimpleArray
    {
        public static void Example()
        {
            // create an array with 5 spaces
            int[] arr1 = new int[5];

            // manually assign to indexes
            arr1[0] = 10;
            arr1[1] = 22;
            arr1[2] = 8;
            arr1[3] = 213;
            arr1[4] = 14;
            // arr1[5] = 1; // error because there are only 5 spaces

            Console.Write("array 1: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]}, ");
            }

            // array with values
            int[] numbers = [10, 20, 30, 40, 50];

            // change array value
            numbers[2] = 1024;

            Console.Write("\narray 2: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
    }
}