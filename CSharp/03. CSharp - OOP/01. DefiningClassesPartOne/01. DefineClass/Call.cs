namespace _01.DefineClass
{
    using System;

    public class Call
    {       
        public Call(DateTime dateTime, string number, TimeSpan duration)
        {
            this.DateTime = dateTime;
            this.DialedNumber = number;
            this.Duration = duration;
        }

        public DateTime DateTime { get; set; }

        public string DialedNumber { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
