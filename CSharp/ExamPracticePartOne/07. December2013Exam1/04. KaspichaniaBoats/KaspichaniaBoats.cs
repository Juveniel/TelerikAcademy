using System;

namespace _04.KaspichaniaBoats
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (n * 2) + 1;
            int height = 6 + ((n - 3) / 2) * 3;

            int dotCount = Math.Abs(width / 2);
            int innerDotsCount = 0;
            int astCount = 1;

            var midPattern = new string('*', astCount);

            #region 
            for (int i = 0; i < n + 1; i++)
            {
                if(i == 0)
                {
                    midPattern = "*";
                }     
                else if(i == 1)
                {
                    midPattern = "***";
                }
                else if(i == n)
                {
                    midPattern = new string('*', width);
                }
                else
                {
                    midPattern = "*" + new string('.', innerDotsCount) + "*" + new string('.', innerDotsCount) + "*";
                }

                Console.WriteLine(new string('.', dotCount) + midPattern + new string('.', dotCount));

                dotCount--;
                if(i >= 1 && i < n - 1)
                {
                    innerDotsCount++;
                }
            }
            #endregion            

            int innerLoopLength = height - n;
            for (int j = 1; j < innerLoopLength; j++)
            {                                   

                if (j == innerLoopLength -1)
                {
                    midPattern = new string('*', Math.Abs(width / 2));
                }
                else
                {
                    midPattern = "*" + new string('.', innerDotsCount) + "*" + new string('.', innerDotsCount) + "*";
                }
                

                Console.WriteLine(new string('.', j) + midPattern + new string('.', j));

                innerDotsCount--;              
            }
        }
    }
}
