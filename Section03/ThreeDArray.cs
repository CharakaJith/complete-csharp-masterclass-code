namespace Section03
{
    static class ThreeDArray
    {
        public static void Example()
        {
            // 3d array with values
            int[,,] cube =
            {
                {
                    {1, 2, 3, 4},
                    {5, 6, 7, 8},
                    {9, 10, 11, 12}
                },
                {
                    {13, 14, 15, 16},
                    {17, 18, 19, 20},
                    {21, 22, 23, 24}
                }
            };

            for (int i = 0; i < cube.GetLength(0); i++)        // layers
            {
                Console.WriteLine($"Layer {i}:");

                for (int j = 0; j < cube.GetLength(1); j++)    // rows
                {
                    for (int k = 0; k < cube.GetLength(2); k++) // columns
                    {
                        Console.Write(cube[i, j, k] + " ");
                    }
                    Console.WriteLine();   // new line per row
                }

                Console.WriteLine();       // blank line between layers
            }

        }
    }
}