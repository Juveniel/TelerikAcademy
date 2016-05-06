using System;

namespace _20.VariationsOfSet
{
    /// <summary>
    /// Write a program that reads two numbers N and K and generates all 
    /// the variations of K elements from the set [1..N].
    /// </summary>
    class VariationsOfSet
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] variations = new int[k];
            GetVariations(variations, 0, n);
        }

        static void GetVariations(int[] array, int index, int elementsLength)
        {
            if (array.Length == index)
            {
                PrintResult(array);
            }
            else
            {
                for (int i = 1; i < elementsLength + 1; i++)
                {
                    array[index] = i;
                    GetVariations(array, index + 1, elementsLength);
                }
            }
        }

        static void PrintResult(int[] numbers)
        {
            Console.Write("{");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

            Console.Write("}");
            Console.WriteLine();
        }

    }
}
