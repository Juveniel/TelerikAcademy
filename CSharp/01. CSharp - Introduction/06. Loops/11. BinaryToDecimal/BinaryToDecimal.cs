using System;


namespace _11.BinaryToDecimal
{
    /// <summary>
    /// Using loops write a program that converts a binary 
    /// integer number to its decimal form.
    /// </summary>
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryNum = Console.ReadLine();

            int decimalRep = 0;
            for (int i = 0; i < binaryNum.Length; i++)
            {
                decimalRep = decimalRep << 1;
                if (binaryNum[i] == '1')
                {
                    decimalRep = decimalRep ^ 1;
                }
            }

            Console.WriteLine(decimalRep);
        }
    }
}
