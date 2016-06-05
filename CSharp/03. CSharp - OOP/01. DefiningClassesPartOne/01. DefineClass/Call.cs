using System;

namespace _01.DefineClass
{
    public class Call
    {
        public DateTime callDateTime { get; set; }
        public string dialedNumber { get; set; }
        public TimeSpan callDuration { get; set; }

        public Call(DateTime dateTime, string number, TimeSpan duration)
        {
            this.callDateTime = dateTime;
            this.dialedNumber = number;
            this.callDuration = duration;
        }      
    }
}
