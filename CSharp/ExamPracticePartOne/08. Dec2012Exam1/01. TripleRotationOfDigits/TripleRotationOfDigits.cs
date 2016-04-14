using System;
using System.Collections.Generic;

namespace _01.TripleRotationOfDigits
{
    class TripleRotationOfDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> digitsList = IntToList(n);
            digitsList.Reverse();

            for (int i = 0; i < 3; i++)
            {
                digitsList.Insert(0, digitsList[digitsList.Count - 1]);
                digitsList.RemoveAt(digitsList.Count - 1);    
                
                if(digitsList[0] == 0)
                {
                    digitsList.RemoveAt(0);
                }           
            }

            string num = string.Join("", digitsList.ToArray());

            Console.WriteLine(num);
        }    

        static List<int> IntToList(int num)
        {
            List<int> digitsList = new List<int>();

            while(num > 0)
            {
                digitsList.Add(num % 10);

                num /= 10;
            }

            return digitsList;
        }
    }
}
