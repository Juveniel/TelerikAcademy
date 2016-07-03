namespace MDLL.TimerEvent
{
    using System;
    using System.Threading;

    public class Timer
    {
        private int interval;        

        public Timer(int interval)
        {
            this.Interval = interval;
        }

        public event EventHandler<TimerEventArgs> RaiseSubscriptionEvent;

        public int Interval
        {
            get
            {
                return this.Interval;
            }

            set
            {
                this.interval = value;
            }
        }

        public void InformAboutNewSubscription()
        {
            this.OnRaiseSubscriptionEvent(new TimerEventArgs("Someone subscribed"));
        }

        protected virtual void OnRaiseSubscriptionEvent(TimerEventArgs ev)
        {
            EventHandler<TimerEventArgs> handler = this.RaiseSubscriptionEvent;

            while (true)
            {
                if (handler != null)
                {
                    Thread.Sleep(this.interval);
                    ev.Time = DateTime.Now;
                    handler(this, ev);
                }
            }            
        }
    }
}
