namespace MDLL.Extensions
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder substring = new StringBuilder();

            if (index < 0 || index > input.Length)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }

            for (int i = index; i < index + length; i++)
            {
                substring.Append(input[i]);
            }

            return substring;
        }
       
        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            StringBuilder substring = new StringBuilder();
            
            if (index < 0 || index > input.Length)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }

            for (int i = index; i < input.Length; i++)
            {
                substring.Append(input[i]);
            }

            return substring;
        }
    }
}
