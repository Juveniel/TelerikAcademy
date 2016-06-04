using System;

namespace _03.SequenceInMatrix
{
    /// <summary>
    /// We are given a matrix of strings of size N x M. Sequences in the matrix we 
    /// define as sets of several neighbour elements located on the same line, column
    /// or diagonal. Write a program that finds the longest sequence of equal strings
    /// in the matrix and prints its length.
    /// </summary>
    class SequenceInMatrix
    {
        static int[] dirRow = { 1, 0, 1, -1 };
        static int[] dirCol = { 0, 1, 1, 1 };

        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            string[,] matrix = FillMatrix(dimensions);

            PrintLongestSequence(matrix);
        }

        static string[,] FillMatrix(string[] dimensions)
        {
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        } 

        static void PrintLongestSequence(string[,] matrix)
        {
            int bestLen = 0;
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    string currentStr = matrix[row, col];
                    int currentLen = 1;

                    for (int direction = 0; direction < 4; direction++)
                    {
                        int currentRow = row;
                        int currentCol = col;
                        while (true)
                        {
                            currentCol += dirCol[direction];
                            currentRow += dirRow[direction];

                            if (currentCol < 0 ||
                                currentCol >= numCols ||
                                currentRow < 0 ||
                                currentRow >= numRows ||
                                currentStr != matrix[currentRow, currentCol])
                            {
                                break;
                            }

                            currentLen++;

                            if (currentLen >= bestLen)
                            {
                                bestLen = currentLen;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(bestLen);
        }
    }
}
