using System;

namespace _02.MaximalSum
{
    /// <summary>
    /// Write a program that reads a rectangular matrix of size N x M and finds in it the square 
    /// 3 x 3 that has maximal sum of its elements. Print that sum. 
    /// </summary>
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            short[,] matrix = FillMatrix(dimensions);

            Console.WriteLine(SumMatrixPlatform(matrix));
        }

        static short[,] FillMatrix(string[] dimensions)
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

        static int SumMatrixPlatform(short[,] matrix)
        {
            int bestSum = int.MinValue;
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum =
                       matrix[row, col] +
                       matrix[row, col + 1] +
                       matrix[row, col + 2] +
                       matrix[row + 1, col] +
                       matrix[row + 1, col + 1] +
                       matrix[row + 1, col + 2] +
                       matrix[row + 2, col] +
                       matrix[row + 2, col + 1] +
                       matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            return bestSum;
        }
    }
}
