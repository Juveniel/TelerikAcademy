using System;

class LoverOf3
{
    static void Main()
    {
        var rowsAndCols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(rowsAndCols[0]);
        int cols = int.Parse(rowsAndCols[1]);

        int[,] matrix = FillMatrix(rows, cols);

        int numberOfDirections = int.Parse(Console.ReadLine());
        int currentRow = matrix.GetLength(0) - 1;
        int currentCol = 0;
        long sum = 0;

        for (int i = 0; i < numberOfDirections; i++)
        {
            var directionAndStep = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string currentDirection = directionAndStep[0];
            int currentStep = int.Parse(directionAndStep[1]);

            if (currentDirection == "RU" || currentDirection == "UR")
            {
                for (int j = 0; j < currentStep - 1; j++)
                {

                    currentRow--;
                    currentCol++;

                    if (currentRow < 0 || currentRow >= matrix.GetLength(0)
                        || currentCol < 0 || currentCol >= matrix.GetLength(1))
                    {
                        if (currentRow < 0)
                        {
                            currentRow++;
                            currentCol--;
                            break;
                        }
                        if (currentCol >= matrix.GetLength(1))
                        {
                            currentCol--;
                            currentRow++;
                            break;
                        }
                    }
                    else
                    {
                        int number = matrix[currentRow, currentCol];
                        sum += number;

                    }
                    matrix[currentRow, currentCol] = 0;
                }
            }

            else if (currentDirection == "LU" || currentDirection == "UL")
            {
                for (int j = 0; j < currentStep - 1; j++)
                {

                    currentRow--;
                    currentCol--;

                    if (currentRow < 0 || currentRow >= matrix.GetLength(0)
                        || currentCol < 0 || currentCol >= matrix.GetLength(1))
                    {
                        if (currentRow < 0)
                        {
                            currentRow++;
                            currentCol++;

                            break;

                        }
                        if (currentCol < 0)
                        {
                            currentCol++;
                            currentRow++;

                            break;

                        }
                    }

                    else
                    {
                        int number = matrix[currentRow, currentCol];
                        sum += number;
                    }
                    matrix[currentRow, currentCol] = 0;
                }
            }

            else if (currentDirection == "DL" || currentDirection == "LD")
            {

                for (int j = 0; j < currentStep - 1; j++)
                {

                    currentRow++;
                    currentCol--;

                    if (currentRow < 0 || currentRow >= matrix.GetLength(0)
                        || currentCol < 0 || currentCol >= matrix.GetLength(1))
                    {
                        if (currentRow >= matrix.GetLength(0))
                        {
                            currentRow--;
                            currentCol++;

                            break;

                        }
                        if (currentCol < 0)
                        {
                            currentCol++;
                            currentRow--;

                            break;

                        }
                    }
                    else
                    {
                        int number = matrix[currentRow, currentCol];
                        sum += number;
                        //sum += matrix[currentRow, currentCol];

                    }
                    matrix[currentRow, currentCol] = 0;
                }
            }

            else if (currentDirection == "DR" || currentDirection == "RD")
            {
                for (int j = 0; j < currentStep - 1; j++)
                {

                    currentRow++;
                    currentCol++;


                    if (currentRow < 0 || currentRow >= matrix.GetLength(0)
                        || currentCol < 0 || currentCol >= matrix.GetLength(1))
                    {
                        if (currentRow >= matrix.GetLength(0))
                        {
                            currentRow--;
                            currentCol--;

                            break;

                        }
                        if (currentCol >= matrix.GetLength(1))
                        {
                            currentCol--;
                            currentRow--;

                            break;

                        }
                    }
                    else
                    {
                        int number = matrix[currentRow, currentCol];
                        sum += number;
                    }
                    matrix[currentRow, currentCol] = 0;

                }
            }
        }

        Console.WriteLine(sum);

    }

    static int[,] FillMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        int startRowsNumber = 0;

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            int number = startRowsNumber;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = number;
                number += 3;
            }
            startRowsNumber += 3;
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }    
}