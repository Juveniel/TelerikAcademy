namespace Bunnies.Utils
{
    using System.Text;

    internal static class StringExtensions
    {
        public static string SplitToSeparateWordsByUppercaseLetter(this string input)
        {
            const int probableStringMargin = 10;
            const char singleWhitespace = ' ';

            var probableStringSize = input.Length + probableStringMargin;           
            var builder = new StringBuilder(probableStringSize);
           
            foreach (var letter in input)
            {
                if (char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}
