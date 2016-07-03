namespace RangeException
{
    using System;

    public class InvalidRangeException<T> : Exception
    {
        private const string ErrorMessage = "Value not in range!";

        public InvalidRangeException()
        {
        }

        public InvalidRangeException(string message, Exception inner) 
            : base(message, inner)
        {
        }

        public InvalidRangeException(T start, T end, string message = ErrorMessage, Exception inner = null)
            : base(message, inner)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }

        public T End { get; private set; }
    }
}
