namespace Events.Models
{
    using System;
    using Events.Contracts;
    using Events.Utils;
    using Wintellect.PowerCollections;

    internal class EventManager : IEventManager
    {
        private MultiDictionary<string, IEvent> eventsByTitle;
        private OrderedBag<IEvent> eventsByDate;

        public EventManager()
        {
            this.eventsByTitle = new MultiDictionary<string, IEvent>(true);
            this.eventsByDate = new OrderedBag<IEvent>();
        }

        public void AddEvent(DateTime date, string title, string location)
        {
            var newEvent = new Event(date, title, location);
            this.eventsByTitle.Add(title.ToLower(), newEvent);
            this.eventsByDate.Add(newEvent);

            MessageLogger.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            var title = titleToDelete.ToLower();
            var removed = 0;
            foreach (var eventToRemove in this.eventsByTitle[title])
            {
                removed++;
                this.eventsByDate.Remove(eventToRemove);
            }

            this.eventsByTitle.Remove(title);

            MessageLogger.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            var eventsToShow = this.eventsByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            var showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                showed++;

                MessageLogger.PrintEvent(eventToShow);                
            }

            if (showed == 0)
            {
                MessageLogger.NoEventsFound();
            }
        }
    }
}
