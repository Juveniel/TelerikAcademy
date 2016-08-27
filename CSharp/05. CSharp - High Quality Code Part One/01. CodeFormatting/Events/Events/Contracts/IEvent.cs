namespace Events.Contracts
{
    using System;

    public interface IEvent : IComparable<IEvent>
    {
        DateTime Date { get; }

        string Title { get; }

        string Location { get; }
    }
}