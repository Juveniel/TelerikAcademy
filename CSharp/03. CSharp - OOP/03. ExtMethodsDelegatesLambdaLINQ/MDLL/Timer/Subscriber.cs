namespace MDLL.TimerEvent
{
    using System;

    public class Subscriber
    {
        private int id;
        private string name;

        public Subscriber(int id, string name, Timer time)
        {
            this.Id = id;
            this.Name = name;

            time.RaiseSubscriptionEvent += this.HandleTimerEvent;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Subscriber id must be positive!");
                }

                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Subscriber name must not be empty");
                }

                this.name = value;
            }
        }
        
        private void HandleTimerEvent(object sender, TimerEventArgs e)
        {
            Console.WriteLine(this.id + " received messgae {0} at {1}", e.Message, e.Time);
        }
    }
}
