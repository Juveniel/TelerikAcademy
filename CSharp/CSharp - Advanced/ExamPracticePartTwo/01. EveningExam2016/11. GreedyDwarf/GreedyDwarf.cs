using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GreedyDwarf
{
    class GreedyDwarf
    {
        private static long ProcessPattern(int[] valley)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[numbers.Length];

            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(numbers[i]);
            }

            bool[] visited = new bool[valley.Length];
            long coinsSum = 0;
            coinsSum += valley[0];
            visited[0] = true;
            int currentPosition = 0;

            while (true)
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    int nextMove = currentPosition + pattern[i];

                    if (nextMove >= 0 && nextMove < valley.Length && !visited[nextMove])
                    {
                        coinsSum += valley[nextMove];
                        visited[nextMove] = true;
                        currentPosition = nextMove;
                    }
                    else
                    {
                        return coinsSum;
                    }
                }
            }           
        }

        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] valleyNumbers = new int[numbers.Length];

            for (int i = 0; i < valleyNumbers.Length; i++)
            {
                valleyNumbers[i] = int.Parse(numbers[i]);
            }

            int numberOfPatterns = int.Parse(Console.ReadLine());
            long bestSum = long.MinValue;

            for (int i = 0; i < numberOfPatterns; i++)
            {
                long sum = ProcessPattern(valleyNumbers);

                if(sum > bestSum)
                {
                    bestSum = sum;
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
