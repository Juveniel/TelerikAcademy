namespace Events.Models
{
    using System;
    using System.Text;
    using Events.Contracts;

    internal class Event : IEvent, IComparable<IEvent>
    {
        private const string DateSeparator = " | ";
        private const string DateFormat = "yyyy-MM-dd THH:mm:ss";

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public int CompareTo(IEvent otherEvent)
        {
            if (otherEvent == null)
            {
                throw new ArgumentException("Event cannot be null");
            }

            var compareByDate = this.Date.CompareTo(otherEvent.Date);
            var compareByLocation = this.Location.CompareTo(otherEvent.Location);
            var compareByTitle = this.Title.CompareTo(otherEvent.Title);

            if (compareByDate == 0)
            {
                return compareByTitle == 0 ? compareByLocation : compareByTitle;
            }
            else
            {
                return compareByDate;
            }                      
        }

        public override string ToString()
        {
            var toString = new StringBuilder();

            toString.Append(this.Date.ToString(DateFormat));
            toString.Append(DateSeparator + this.Title);

            if (!string.IsNullOrEmpty(this.Location))
            {
                toString.Append(DateSeparator + this.Location);
            }

            return toString.ToString();
        }
    }
}
