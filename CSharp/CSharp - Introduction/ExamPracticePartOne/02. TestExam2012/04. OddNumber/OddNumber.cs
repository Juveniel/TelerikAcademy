using System;
using System.Linq;

namespace _04.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] inputList = new long[n];
           
            if(n >= 1 && n <= 99999)
            {
                for (int i = 0; i < n; i++)
                {
                    inputList[i] = long.Parse(Console.ReadLine());
                }

                var groups = inputList.GroupBy(item => item);
                foreach(var t in groups)
                {
                    if(t.Count() % 2 == 1)
                    {
                        Console.WriteLine(t.Key);
                        break;
                    }
                }                
            }           
        }       
    }            
}
