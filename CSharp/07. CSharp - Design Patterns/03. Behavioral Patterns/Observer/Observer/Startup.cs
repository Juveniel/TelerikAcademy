using System;
using Observer.Models;

namespace Observer
{
    public class Startup
    {
        public static void Main()
        {
            // Configure Observer pattern
            var subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "X"));
            subject.Attach(new ConcreteObserver(subject, "Y"));
            subject.Attach(new ConcreteObserver(subject, "Z"));

            // Change subject and notify observers
            subject.SubjectState = "ABC";
            subject.Notify();
        }
    }
}
