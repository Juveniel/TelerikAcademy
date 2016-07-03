namespace BitArray64
{
    using System;
    using Models;

    public class Startup
    {
        internal static void Main()
        {
            // 1. Test index
            var firstNum = new BitArray64(123);
            firstNum[2] = 1;
            firstNum[7] = 1;
            Console.WriteLine(firstNum);
        
            var secondNum = new BitArray64(123231);
            Console.WriteLine(secondNum);

            // 2.Test Equals & boolean
            Console.WriteLine("number1.Equals(number2): {0}", firstNum.Equals(secondNum));
            Console.WriteLine("number1 == number2: {0}", firstNum == secondNum);
            Console.WriteLine("number1 != number2: {0}\n", firstNum != secondNum);

            // 3. Test hashcode
            Console.WriteLine("number1.GetHashCode(): {0}", firstNum.GetHashCode());

            // 4.Test enumerator
            Console.WriteLine("\nEnum test");
            foreach (var bit in firstNum)
            {
                Console.Write(bit);
            }             

            Console.WriteLine();
        }
    }
}
