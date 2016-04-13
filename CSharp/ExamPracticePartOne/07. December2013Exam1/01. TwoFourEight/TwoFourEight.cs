using System;
using System.Collections.Generic;

namespace _01.TwoFourEight
{
    class TwoFourEight
    {
        static void Main(string[] args)
        {
            List<long> numebrsList = new List<long>();
            for(int i = 0; i < 3; i++)
            {
                long n = long.Parse(Console.ReadLine());
                numebrsList.Add(n);          
            }

            long r = TransformCode(numebrsList);
            
            if(r % 4 == 0)
            {
                Console.WriteLine(r / 4);
            }
            else
            {
                Console.WriteLine(r % 4);
            }

            Console.WriteLine(r);

        }  
        
        static long TransformCode(List<long> numbers)
        {
            long transformedCode = 0;
            long num = numbers[1];

            switch (num)
            {
                case 2:
                    transformedCode = numbers[0] % numbers[2];
                    break;
                case 4:
                    transformedCode = numbers[0] + numbers[2];
                    break;
                case 8:
                    transformedCode = numbers[0] * numbers[2];
                    break;
                default:
                    break;
            }
            
            return transformedCode;
        } 
    }
}
