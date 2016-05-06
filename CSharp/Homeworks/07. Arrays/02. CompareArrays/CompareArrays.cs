using System;

namespace _02.CompareArrays
{
    /// <summary>
    /// Write a program that reads two integer arrays from the console 
    /// and compares them element by element.
    /// </summary>
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
                       
            int[] numArrOne = new int[arrLength];
            int[] numArrTwo = new int[arrLength];

            for(int i = 0; i < arrLength; i++)
            {
                numArrOne[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arrLength; j++)
            {
                numArrTwo[j] = int.Parse(Console.ReadLine());
            }

            bool areEqual = AreEqual(numArrOne, numArrTwo);
            if (areEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");               
            }            
        }

        private static bool AreEqual(int[] arrOne, int[] arrTwo)
        {
            bool areEqual = true;
            for (int i = 0; i < arrOne.Length; i++)
            {               
                if (arrOne[i] != arrTwo[i])
                {
                    areEqual = false;
                }                
            }

            return areEqual;
        }
    }
}
