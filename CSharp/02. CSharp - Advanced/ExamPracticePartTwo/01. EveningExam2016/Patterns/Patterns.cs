using System;

namespace Patterns
{
    class Patterns
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int maxSum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            for (int i = 0; i + 2 < n; i++)
            {
                for (int j = 0; j + 4 < n; j++)
                {
                    if(matrix[i, j] + 1 == matrix[i, j + 1] &&                                      
                        matrix[i, j] + 2 == matrix[i, j + 2] &&
                        matrix[i, j] + 3 == matrix[i + 1, j + 2] &&
                        matrix[i, j] + 4 == matrix[i + 2, j + 2] &&
                        matrix[i, j] + 5 == matrix[i + 2, j + 3] &&
                        matrix[i, j] + 6 == matrix[i + 2, j + 4])
                    {
                        int sum = 7 * matrix[i, j] + 21; // 0 + 1 + 2 + 3 + 4 + 5 + 6 = 21 and is consisted of 7 digits

                        if(maxSum < sum)
                        {
                            maxSum = sum;
                        }
                    }                                        
                }               
            }

            Console.WriteLine("YES {0}", maxSum);

        }
    }
}
