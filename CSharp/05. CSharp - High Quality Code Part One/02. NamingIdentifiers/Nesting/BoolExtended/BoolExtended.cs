namespace BoolExtended
{
    using System;

    public class BoolExtended
    {
        private const int MaxCount = 6;    
           
        public static void Main()
        {
            var converter = new BoolConverter();

            converter.PrintBoolToString(true);
        }

        internal class BoolConverter
        {
            public void PrintBoolToString(bool valueToConvert)
            {
                var boolAsString = valueToConvert.ToString();
                Console.WriteLine(boolAsString);
            }
        }
    }
}
