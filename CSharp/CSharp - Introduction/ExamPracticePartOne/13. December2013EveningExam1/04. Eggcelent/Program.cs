using System;

namespace _04.Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = 3 * n + 1;

            int dotsCount = n + 1;
            string middle = new string('*', n - 1);
            for(int i = 0; i < n - 1; i++)
            {
                if(i > 0)
                {
                    middle = "*" + new string('.', ((width - 2) - dotsCount * 2)) + "*";
                }

                Console.WriteLine(new string('.', dotsCount) + middle + new string('.', dotsCount));

                if(dotsCount > 2)
                {
                    dotsCount -= 2;
                }
              
            }

            for(int j = 0; j < 1; j++)
            {
                Console.Write(".*");
                for(int k = 0; k < width - 4; k++)
                {
                    if(k % 2 == 0)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.Write("*.");
                Console.WriteLine();
            }

            for (int j = 0; j < 1; j++)
            {
                Console.Write(".*");
                for (int k = 0; k < width - 4; k++)
                {
                    if (k % 2 == 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("@");
                    }
                }
                Console.Write("*.");
                Console.WriteLine();
            }

            /* int bottomDotsCount = 1;
             int middleDotsCount = ((width - 2) - bottomDotsCount * 2);
             string bottomMiddle = "";
             for (int s = 0; s < n - 1; s++)
             {
                 bottomMiddle = "*" + new string('.', middleDotsCount) + "*";
                 if (s == n - 2)
                 {
                     bottomDotsCount =  (width - n + 1) / 2;
                     bottomMiddle = new string('*', n - 1);
                 }

                 Console.WriteLine(new string('.', bottomDotsCount) + bottomMiddle + new string('.', bottomDotsCount));

                 bottomDotsCount += 2;
                 middleDotsCount -= 4;
             }*/

            
            int middleCont = ((width - 2) - dotsCount * 2);
            int bottomDotsCount = width - middleCont - 3;
            string bottomMiddle = "";
            for (int i = n -1; i > 0; i--)
            {
                if(i > 1)
                {
                    bottomMiddle = "*" + new string('.', middleCont) + "*";
                }
 
         
             
                if (i == 1)
                {
                    bottomMiddle = new string('*', n - 1); 
                }


                Console.WriteLine(new string('.', bottomDotsCount) + bottomMiddle + new string('.', bottomDotsCount));

                        
                bottomDotsCount += 2;  
                if(middleCont > 4)
                {
                    middleCont -= 4;
                }              
             
            }

        }
    }
}
