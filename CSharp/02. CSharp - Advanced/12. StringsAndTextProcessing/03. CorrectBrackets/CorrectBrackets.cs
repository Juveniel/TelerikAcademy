using System;

namespace _03.CorrectBrackets
{
    /// <summary>
    /// Write a program to check if in a given expression the brackets are put correctly.
    /// </summary>
    class CorrectBrackets
    {
        const char LeftParenthesis = '(';
        const char RightParenthesis = ')';

        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            bool isExpCorrect = CheckBrackets(userInput);

            if (isExpCorrect)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }

        static bool CheckBrackets(string text)
        {
            bool isCorrect = false;
            int bracketsCounter = 0;

            for(int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case LeftParenthesis:
                        bracketsCounter++;
                        break;
                    case RightParenthesis:
                        bracketsCounter--;
                        break;
                    default:
                        continue;
                }
            }

            if(bracketsCounter == 0)
            {
                isCorrect = true;
            }

            return isCorrect;
        }
    }
}
