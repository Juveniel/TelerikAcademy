namespace Events.Contracts
{
    using System;

    public interface IEventManager
    {
        void AddEvent(DateTime date, string title, string location);

        void DeleteEvents(string titleToDelete);

        void ListEvents(DateTime date, int count);
    }
}