using System;

namespace _07.LargestArea
{
    /// <summary>
    /// Write a program that finds the largest area of equal neighbour 
    /// elements in a rectangular matrix and prints its size.
    /// </summary>
    class LargestArea
    {
        private static int currentArea = 0;
        private static int[,] Directions =
         {
             // down
             { 1, 0 },

             // right
             { 0, 1 },

             // up
             { -1, 0 },

             // left
             { 0, -1 }
         };

        private static void Main()
        {
            string[] dimensions = Console.ReadLine().Split();
            short[,] matrix = FillMatrix(dimensions);

            int largestArea = FindLargestArea(matrix);
            Console.WriteLine(largestArea);
        }

        private static short[,] FillMatrix(string[] dimensions)
        {
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            short[,] matrix = new short[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = short.Parse(input[col]);
                }
            }

            return matrix;
        }

        private static bool IsPassable(short[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void DepthFirstSearch(short[,] matrix, int row, int col)
        {
            short value = matrix[row, col];

            matrix[row, col] = 0;
            currentArea++;

            int newRow = 0;
            int newCol = 0;
            for (short i = 0; i < Directions.GetLength(0); i++)
            {
                newRow = row + Directions[i, 0];
                newCol = col + Directions[i, 1];

                if (IsPassable(matrix, newRow, newCol) && matrix[newRow, newCol] == value)
                {
                    DepthFirstSearch(matrix, newRow, newCol);
                }
            }
        }

        private static int FindLargestArea(short[,] matrix)
        {
            int bestArea = 0;
            for (short i = 0; i < matrix.GetLength(0); i++)
            {
                for (short j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        currentArea = 0;
                        DepthFirstSearch(matrix, i, j);

                        if (currentArea > bestArea)
                        {
                            bestArea = currentArea;
                        }
                    }
                }
            }

            return bestArea;
        }
    }
}
