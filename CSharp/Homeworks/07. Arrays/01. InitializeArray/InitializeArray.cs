using System;

namespace _01.InitializeArray
{
    /// <summary>
    /// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    /// </summary>

    class InitializeArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbersArr = new int[n];    
                
            for(int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = i * 5;
                Console.WriteLine(numbersArr[i]);
            }
        }
    }
}
