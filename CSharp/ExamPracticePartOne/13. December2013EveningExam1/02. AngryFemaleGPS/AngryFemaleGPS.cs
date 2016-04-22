using System;

namespace _02.AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if (n < 0)
            {
                n *= -1;
            }

            string nText = n.ToString();
            long evenDigitsCount = 0;
            long oddDigitsCount = 0;
            for(int i = 0; i < nText.Length; i++)
            {
                int current = int.Parse(nText[i].ToString());
                
                if(current % 2 == 0)
                {
                    evenDigitsCount += current;
                }
                else
                {
                    oddDigitsCount += current;
                }            
            }

            if(evenDigitsCount > oddDigitsCount)
            {
                Console.WriteLine("right {0}", evenDigitsCount);
            }
            else if(oddDigitsCount > evenDigitsCount)
            {
                Console.WriteLine("left {0}", oddDigitsCount);
            }
            else
            {
                Console.WriteLine("straight {0}", evenDigitsCount);
            }



        }
    }
}
