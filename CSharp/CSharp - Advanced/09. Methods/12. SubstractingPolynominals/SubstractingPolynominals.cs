using System;

namespace _12.SubstractingPolynominals
{
    /// <summary>
    /// Extend the previous program to support also subtraction and multiplication of polynomials.
    /// </summary>
    class SubstractingPolynominals
    {
        static void Main(string[] args)
        {
            short size = short.Parse(Console.ReadLine());
            short[] firstPolynominalsArr = FillArray(size);
            short[] secondPolynominalsArr = FillArray(size);

            int[] polynominalSubstracted = SubstractionOfPolynomials(firstPolynominalsArr, secondPolynominalsArr);

            PrintPolynominals(polynominalSubstracted);
        }

        static short[] FillArray(short size)
        {
            short[] arrNumbers = new short[size];
            var line = Console.ReadLine().Split(' ');

            for (int i = 0; i < size; i++)
            {
                arrNumbers[i] = short.Parse(line[i]);
            }

            return arrNumbers;
        }

        static int[] SubstractionOfPolynomials(short[] firstPolynomial, short[] secondPolynomial)
        {
            int[] result = new int[firstPolynomial.Length];
            int minLenght = 0;
            int smallerPolinomial = 0;

            if (firstPolynomial.Length > secondPolynomial.Length)
            {
                minLenght = secondPolynomial.Length;
                smallerPolinomial = 2;
            }
            else
            {
                minLenght = firstPolynomial.Length;
                smallerPolinomial = 1;
            }

            for (int i = 0; i < minLenght; i++)
            {
                result[i] = firstPolynomial[i] - secondPolynomial[i];
            }

            for (int i = minLenght; i < result.Length; i++)
            {
                if (smallerPolinomial == 1)
                {
                    result[i] = secondPolynomial[i];
                }
                else
                {
                    result[i] = firstPolynomial[i];
                }
            }

            return result;
        }

        static void PrintPolynominals(int[] polynominals)
        {
            foreach (var num in polynominals)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}
