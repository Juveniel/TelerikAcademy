namespace MDLL.TimerEvent
{
    using System;

    public class TimerEventArgs : EventArgs
    {
        private string message;
        private DateTime time;

        public TimerEventArgs(string msg)
        {
            this.Message = msg;
            this.Time = DateTime.Now;
        }

        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Message cannot be empty !");
                }

                this.message = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }  
            
            set
            {
                this.time = value;
            }                 
        }
    }
}
