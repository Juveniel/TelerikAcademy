using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortThreeNumbers
{
    class SortThreeNumbers
    {      

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNum = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int thirdNum = CheckInputFormat(Console.ReadLine());

            if(firstNum < secondNum)
            {                            
                if(firstNum > thirdNum)
                {
                     SwapValues(ref firstNum,ref thirdNum);
                }                
            }
            else
            {
                if(secondNum < thirdNum)
                {                    
                    SwapValues(ref firstNum, ref secondNum);
                }
                else
                {
                    SwapValues(ref firstNum, ref thirdNum);
                }
            }

           
            if (secondNum > thirdNum)
            {
                SwapValues(ref secondNum, ref thirdNum);
            }

            Console.WriteLine("===/=== RESULT SORTED ===/===");
            Console.WriteLine(firstNum + " " + secondNum + " " + thirdNum);
        }

        public static int CheckInputFormat(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }

        public static void SwapValues(ref int firstNum, ref int secondNum)
        {
            int tempswap = firstNum;
            firstNum = secondNum;
            secondNum = tempswap;         
        }
    }
}
