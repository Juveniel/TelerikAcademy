using System;
using System.Collections.Generic;

namespace _02.ReversePolishNotation
{
    public class ReversePolishNotation
    {
        public static void Main()
        {
            var sp = new char[] { ' ', '\t' };
            for (;;)
            {
                var expression = Console.ReadLine();
                if (expression == null)
                {
                    break;
                }

                var ticks = new Stack<string>(expression.Split(sp, StringSplitOptions.RemoveEmptyEntries));
                if (ticks.Count == 0)
                {
                    continue;
                }
                try
                {
                    var r = Rpn(ticks);
                    if (ticks.Count != 0)
                    {
                        throw new Exception();
                    }

                    Console.WriteLine(r);
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                }
            }
        }

        private static int Rpn(Stack<string> tks)
        {
            var tk = tks.Pop();
            int x;
            if (int.TryParse(tk, out x))
            {
                return x;
            }

            var y = Rpn(tks);
            x = Rpn(tks);

            switch (tk)
            {
                case "+":
                    x += y;
                    break;
                case "-":
                    x -= y;
                    break;
                case "*":
                    x *= y;
                    break;
                case "/":
                    x /= y;
                    break;
                case "&":
                    x &= y;
                    break;
                case "|":
                    x |= y;
                    break;
                case "^":
                    x ^= y;
                    break;
                default:
                    throw new Exception();
            }

            return x;
        }
    }
}
