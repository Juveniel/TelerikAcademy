using System;

namespace _04.BatGoikosTower
{
    class BatGoikosTower
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char dot = '.';
            char forwardSlash = '/';
            char backslash = '\\';
            char whSpace = ' ';

            int dotCount = n - 1;
            int whSpaceCount = 0;
            int dashRowIndex = 1;
            int beamCounter = 2; 

            for (int i = 0; i < n; i++)
            {
                if(i == dashRowIndex)
                {
                    dashRowIndex = (i + beamCounter);
                    beamCounter++;
                    whSpace = '-';
                }
                else if(i == 0)
                {
                    whSpace = ' ';
                }
                else
                {
                    whSpace = '.';
                }

                Console.WriteLine(new string(dot, dotCount) + forwardSlash + new string(whSpace, whSpaceCount   ) +
                                  backslash +  new string(dot, dotCount));

                dotCount--;
                whSpaceCount += 2;                           
            }
        }
    }
}
