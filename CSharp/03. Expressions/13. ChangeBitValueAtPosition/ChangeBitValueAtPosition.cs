using System;

namespace _13.ChangeBitValueAtPosition
{
    class ChangeBitValueAtPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter position of bit: ");
            int bitPosition = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value: ");
            int bitChangeVal = int.Parse(Console.ReadLine());

            int mask = 0;
            int newNumber = 0;

            if (bitChangeVal == 1)
            {
                mask = 1 << bitPosition;
                newNumber = inputNum | mask;
            }
            else
            {
                mask = ~(1 << bitPosition);
                newNumber = inputNum & mask;
            }

            //Check result
            Console.Write("Binary: ");
            Console.WriteLine(Convert.ToString(inputNum, 2).PadLeft(32, '0'));

            Console.Write("Mask:   ");        
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));

            Console.Write("Result: ");
            Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
        }
    }
}
