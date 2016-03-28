using System;
using System.Collections.Generic;

namespace _04.BinaryDigitsCount
{  
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());
           
            List<uint> inputList = new List<uint>();
            for (int i = 0; i < n; i++)
            {
                inputList.Add(uint.Parse(Console.ReadLine()));
            }
               
            List<uint> results = new List<uint>();
            foreach (uint num in inputList)
            {
                if(b == 0)
                {                   
                    results.Add(CountZeroes(num));
                }
                else
                {
                    results.Add(CountOnes(num));
                }                   
            }
          
            foreach (var num in results)
            {
                Console.WriteLine(num);
            }                                  
        }     
                
        static uint CountOnes(uint num)
        {
            uint count = 0;
       
            while (num > 0)
            {
                count = count + 1;
                num = num & (num - 1);
            }

            return count;
        }

        static uint CountZeroes(uint num)
        {
            uint count = 0;
            while(num != 0)
            {
                if((num & 1) != 1)
                {
                    count++;
                }

                num >>= 1;
            }

            return count;
        }      
    }
}
