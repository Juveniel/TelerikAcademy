using System;

namespace _01.FillMatrix
{
    /// <summary>
    /// Write a program that fills and prints a matrix of size (n, n)
    /// </summary>
    class FillMatrix
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char matrixType = char.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];
           
            switch (matrixType)
            {
                case 'a':
                    MatrixTypeA(matrix);
                    break;
                case 'b':
                    MatrixTypeB(matrix);
                    break;
                case 'c':
                    MatrixTypeC(matrix);
                    break;
                case 'd':
                    MatrixTypeD(matrix);
                    break;
                default:
                    Console.WriteLine("No such type");
                    break;
            }
        }

        static void MatrixTypeA(int[,] matrix)
        {
            int counter = 1;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {                
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }                
            }

            PrintMatrix(matrix);
        }

        static void MatrixTypeB(int[,] matrix)
        {
            int counter = 1;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(1) - 1; row > -1; row--)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void MatrixTypeC(int[,] matrix)
        {
            int counter = 1;
            int matrixLength = matrix.GetLength(0);
            for (int start = 0; start < matrixLength; start++)
            {
                for (int i = matrixLength - start - 1, j = 0; i < matrixLength && j < matrixLength; i++, j++)
                {
                    matrix[i, j] = counter++;
                }
            }

            for (int start = matrixLength - 1; start > 0; start--)
            {
                for (int i = 0, j = matrixLength - start; i < matrixLength && j < matrixLength; i++, j++)
                {
                    matrix[i, j] = counter++;
                }
            }

            PrintMatrix(matrix);
        }

        static void MatrixTypeD(int[,] matrix)
        {
            int positionX = 0;
            int positionY = 0;

            int matrixLength = matrix.GetLength(0);
            int direction = 0;
            int stepsCount = matrixLength - 1;
            int stepPosition = 1; 
            int counter = 0; 

            for (int i = 1; i < matrixLength * matrixLength + 1; i++)
            {
                matrix[positionX, positionY] = i;

                if (stepPosition <= stepsCount)
                {
                    stepPosition++;
                }
                else
                {
                    counter++;
                    stepPosition = 1;

                    if (counter % 2 != 0)
                    {
                        stepsCount = stepsCount - 1;
                        direction = (direction + 1) % 4;
                    }
                    else if (counter % 2 == 0)
                    {
                        direction = (direction + 1) % 4;
                    }

                }

                switch (direction)
                {
                    case 0:
                        // right
                        positionX++;
                        break;
                    case 1:
                        // down
                        positionY++;
                        break;
                    case 2:
                        // left
                        positionX--;
                        break;
                    case 3:
                        // up
                        positionY--;
                        break;
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);

                    if(col < matrix.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
              
            }
        }
    }
}
