namespace Events
{
    using System;
    using System.Text;

    internal class Event : IComparable<Event>
    {     
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        } 

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public int CompareTo(Event otherEvent)
        {          
            var byDate = this.Date.CompareTo(otherEvent.Date);
            var byTitle = string.Compare(this.Title, otherEvent.Title, StringComparison.Ordinal);
            var byLocation = string.Compare(this.Location, otherEvent.Location, StringComparison.Ordinal);

            if (byDate == 0)
            {
                return byTitle == 0 ? byLocation : byTitle;
            }
            else
            {
                return byDate;
            }            
        }  

        public override string ToString()
        {
            var toString = new StringBuilder();

            toString.Append(this.Date.ToString("yyyy-MM-dd THH:mm:ss"));
            toString.Append(" | " + this.Title);

            if (!string.IsNullOrEmpty(this.Location))
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }   
    }
}
