using System;

namespace _04.UkFlag
{
    class UkFlag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int innerDotsCounter = (n - 3) / 2;
            int outerDotsCount = 0;
            for(int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', outerDotsCount) + '\\' + new string('.', innerDotsCounter) + '|' 
                                    + new string('.', innerDotsCounter) + '/' + new string('.', outerDotsCount));

                innerDotsCounter--;
                outerDotsCount++;
            }

            Console.WriteLine(new string('-', n /2) + '*' + new string('-', n / 2));
            outerDotsCount = (n - 3) / 2;
            for (int i = 0; i < n / 2; i++)
            {
                innerDotsCounter = i;
                

                Console.WriteLine(new string('.', outerDotsCount) + '/' + new string('.', innerDotsCounter) + '|'
                                   + new string('.', innerDotsCounter) + '\\' + new string('.', outerDotsCount));

                outerDotsCount--;
            }
        }
    }
}
