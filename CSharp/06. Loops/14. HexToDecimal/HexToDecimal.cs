using System;

namespace _14.HexToDecimal
{
    /// <summary>
    /// Using loops write a program that converts a
    /// hexadecimal integer number to its decimal form.
    /// </summary>
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();

            long result = 0;
            char[] inputArr = inputNum.ToCharArray();
            Array.Reverse(inputArr);           

            for(int i = 0; i < inputArr.Length; i++)
            {
                int power = i;

                switch (inputArr[i])
                {
                    case 'A':
                        result += 10 * (long)Math.Pow(16, power);
                        break;
                    case 'B':
                        result += 11 * (long)Math.Pow(16, power);
                        break;
                    case 'C':
                        result += 12 * (long)Math.Pow(16, power);
                        break;
                    case 'D':
                        result += 13 * (long)Math.Pow(16, power);
                        break;
                    case 'E':
                        result += 14 * (long)Math.Pow(16, power);
                        break;
                    case 'F':
                        result += 15 * (long)Math.Pow(16, power);
                        break;
                    default:
                        result += long.Parse(inputArr[i].ToString()) * (long)Math.Pow(16, power);
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
