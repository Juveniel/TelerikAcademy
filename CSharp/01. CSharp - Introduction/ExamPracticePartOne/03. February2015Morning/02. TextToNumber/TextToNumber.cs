using System;

class TextToNumber
{
    static void Main(string[] args)
    {
        short m = short.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        char[] arrInputChars = input.ToCharArray();
        PrintResult(arrInputChars, m);                             
    }

    static void PrintResult(char[] inputArr, short module)
    {
        long result = 0;
        var symbol = '\u0040';

        foreach (char c in inputArr)
        {          
            if (IsInteger(c))
            {
                result *= long.Parse(c.ToString());
            }
            else if (IsLetter(c))
            {
                result += GetLetterIndex(c);
            }
            else if (c == symbol)
            {
                break;
            }
            else
            {
                result %= module;
            }
        }
        Console.WriteLine(result);
    }

    static bool IsInteger(char c)
    {      
        return Char.IsNumber(c);
    }

    static bool IsLetter(char c)
    {
        return Char.IsLetter(c);
    }

    static int GetLetterIndex(char c)
    {
        int index = char.ToUpper(c) - 64;

        return index - 1;
    }
}

