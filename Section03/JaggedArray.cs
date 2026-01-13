namespace Section03
{
    static class JaggedArray
    {
        public static void Example()
        {
            // create a jagged array
            int[][] jaggedArr = new int[3][];

            // manually asign values
            jaggedArr[0] = new int[] { 1, 2, 3 };
            jaggedArr[1] = new int[] { 4, 5 };
            jaggedArr[2] = new int[] { 6, 7, 8, 9, 10 };

            Console.WriteLine("jagged array 1: ");
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j]} ");
                }
                Console.WriteLine();
            }

            // jagged array with values
            int[][] jaggedArr2 =
            {
                new int[] {1, 2, 3, 4, 5},
                new int[] { 6, 7 },
                new int[] { 8, 9, 10 },
            };

            Console.WriteLine("\njagged array 1: ");
            for (int i = 0; i < jaggedArr2.Length; i++)
            {
                for (int j = 0; j < jaggedArr2[i].Length; j++)
                {
                    Console.Write($"{jaggedArr2[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}