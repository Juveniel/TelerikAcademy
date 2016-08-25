namespace Events
{
    using System;
    using System.Collections.Generic;

    internal class EventHolder
    {
        private readonly Dictionary<string, Event> eventsList;

        OrderedBag<Event>byDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date,
                             string title,
                              string location)
        {
            Event newEvent = new Event(date,
                                       title,
                                       location);
            byTitle.Add(
                        title.ToLower(),
                        newEvent
                        );
            byDate.Add(newEvent); Messages.EventAdded();
        }

        public void DeleteEvents(string title)
        {
            var title = titleToDelete.ToLower();
            var removed = 0;

            foreach (var eventToRemove in byTitle[title])
            {
                removed++;
                byDate.Remove(eventToRemove);
            }
            byTitle.Remove(title);
            Messages.EventDeleted(removed);
        }
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View
                    eventsToShow = byDate.RangeFrom(new Event(
                    date, "", ""),
                    true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count) break;
                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
