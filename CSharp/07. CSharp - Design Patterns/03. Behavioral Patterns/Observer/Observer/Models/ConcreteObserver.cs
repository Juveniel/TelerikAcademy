using System;

namespace Observer.Models
{
    internal class ConcreteObserver : Abstract.Observer
    {
        
        private string name;        
        private string observerState;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.Subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = Subject.SubjectState;

            Console.WriteLine($"Observer {name}'s new state is {observerState}");
        }

        private ConcreteSubject Subject { get; set; }
    }    
}
