namespace Exceptions.Utils
{
    using System;
    using System.Text;

    public static class StringHelper
    {
        public static string ExtractEnding(string text, int count)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Text cannot be null or empty!");
            }

            if (count > text.Length)
            {
                throw new ArgumentOutOfRangeException("Count cannot be bigger than text length!");   
            }

            var result = new StringBuilder();        
            for (var i = text.Length - count; i < text.Length; i++)
            {
                result.Append(text[i]);
            }

            return result.ToString();
        }
    }
}
