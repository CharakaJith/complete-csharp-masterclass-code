namespace Section03
{
    static class TwoDArray
    {
        public static void Example()
        {
            // create a 2d array
            int[,] matrix = new int[2, 3];

            // manually assign indexes
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;

            Console.WriteLine("matrix 1: ");
            for (int i = 0; i < matrix.GetLength(0); i++)  // rows
            {           
                for (int j = 0; j < matrix.GetLength(1); j++)  // columns
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();   // move to next line after each row
            }

            // 2d array with values
            int[,] matrix2 = {{1, 2, 3}, {4, 5, 6}};

            // change array values
            matrix2[0, 1] = 16;
            matrix2[1, 1] = 32;

            Console.WriteLine("\nmatrix 2: ");

            int columns = matrix.GetLength(1);
            int count = 0;
            foreach (int value in matrix)
            {
                Console.Write(value + " ");
                count++;

                if (count % columns == 0)
                    Console.WriteLine();
            }
        }
    }
}