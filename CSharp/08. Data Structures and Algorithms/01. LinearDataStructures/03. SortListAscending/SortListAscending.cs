using System;
using System.Collections.Generic;

namespace _03.SortListAscending
{
    public class SortListAscending
    {
        public static void Main()
        {
            var inputList = new List<int>();
            while (true)
            {
                var nextLine = Console.ReadLine();
                if (string.IsNullOrEmpty(nextLine))
                {
                    break;
                }

                int next;
                var isInteger = int.TryParse(nextLine, out next);
                if (isInteger)
                {
                    inputList.Add(next);
                }
            }

            for (var i = 0; i < inputList.Count - 1; i++)
            {
                for (var j = i + 1; j < inputList.Count; j++)
                {
                    if (inputList[i] > inputList[j])
                    {
                        var tmp = inputList[i];
                        inputList[i] = inputList[j];
                        inputList[j] = tmp;
                    }
                }
            }

            inputList.ForEach(i => Console.Write("{0}, ", i));
        }
    }
}
