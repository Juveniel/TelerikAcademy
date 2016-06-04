using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.BitShiftMatrix
{
    class BitShiftMatrix
    {
        static void Main(string[] args)
        {
            long rows = int.Parse(Console.ReadLine());
            long cols = int.Parse(Console.ReadLine());
            long max = Math.Max(rows, cols);
            long movesAmount = int.Parse(Console.ReadLine());
            long[] directions = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long[,] matrix = FillMatrix(rows, cols);

            List<long> rowsOfThePawn = new List<long>();
            List<long> colsOfThePawn = new List<long>();
            for (int i = 0; i < directions.Length; i++)
            {
                rowsOfThePawn.Add(directions[i] / max);
                colsOfThePawn.Add(directions[i] % max);
            }

            long finalResult = 0;
            long row = matrix.GetLength(0) - 1;
            long col = 0;
            for (long i = 0; i < movesAmount; i++)
            {
                if (col < colsOfThePawn[(int)i])
                {
                    for (long c = col; c <= colsOfThePawn[(int)i]; c++)
                    {
                        finalResult += matrix[(int)row, (int)c];
                        matrix[(int)row, (int)c] = 0;
                        col = c;
                    }
                }
                else
                {
                    for (long c = col; c >= colsOfThePawn[(int)i]; c--)
                    {
                        finalResult += matrix[(int)row, (int)c];
                        matrix[(int)row, (int)c] = 0;
                        col = c;
                    }
                }

                if (row < rowsOfThePawn[(int)i])
                {
                    for (long r = row; r <= rowsOfThePawn[(int)i]; r++)
                    {
                        finalResult += matrix[(int)r, (int)col];
                        matrix[(int)r, (int)col] = 0;
                        row = r;
                    }
                }
                else
                {
                    for (long r = row; r >= rowsOfThePawn[(int)i]; r--)
                    {
                        finalResult += matrix[(int)r, (int)col];
                        matrix[(int)r, (int)col] = 0;
                        row = r;
                    }
                }

            }

            Console.WriteLine(finalResult);
        }

        static long[,] FillMatrix(long rows, long cols)
        {
            long[,] matrix = new long[rows, cols];
            int startRowsNumber = 1;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                long number = startRowsNumber;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[(int)row, (int)col] = number;
                    number *= 2;
                }
                startRowsNumber *= 2;
            }
            return matrix;
        }      
    }
}
