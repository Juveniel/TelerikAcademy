namespace Matrix.Utils
{
    using System;
    using Contracts;

    public class Writer : IWriter
    {
        public void Write(string format = null, object obj = null)
        {
            if (format != null)
            {
                Console.Write($"{format}", obj);
            }
            else
            {
                Console.Write(obj);
            }
        }

        public void WriteLine(string format = null, object obj = null)
        {
            if (format != null)
            {
                Console.WriteLine($"{format}", obj);
            }
            else
            {
                Console.WriteLine(obj);
            }
        }
    }
}
