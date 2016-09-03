namespace Loop
{
    using System;
      
    public class Loop
    {
        internal static void Main()
        {           
        }

        internal static void ExecuteLoop(int[] numbers, int expectedValue)
        {
            var expectedValueFound = false;

            for (var i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(numbers[i]);

                    if (numbers[i] == expectedValue)
                    {
                        expectedValueFound = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }  
    }
}
