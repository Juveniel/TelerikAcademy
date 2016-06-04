using System;

namespace _06.EvenDifferenced
{
    class EvenDifferenced
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');

            Console.WriteLine(FindAbsolutenUmbersSum(inputNumbers));
        }

        static long FindAbsolutenUmbersSum(string[] numbers)
        {
            long sum = 0;
            int startIdx = 0;

            for(int i = 1; i < numbers.Length - 2; i++)
            {            
                long currentNum = int.Parse(numbers[startIdx]);
                long nextNum = int.Parse(numbers[startIdx + 1]);
                long currentSum = Math.Abs(nextNum - currentNum);

                if(currentSum % 2 == 0)
                {
                    startIdx += 2;
                    sum += currentSum;
                }
                else
                {
                    startIdx += 1;
                }               
            }

            return sum;
        }
    }
}
