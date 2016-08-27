namespace Events.Utils
{
    using System.Text;
    using Events.Contracts;
    using Events.Models;

    internal static class MessageLogger
    {
        private static readonly StringBuilder Output = new StringBuilder();

        public static string PrintOutput()
        {
            return Output.ToString();
        }

        public static void EventAdded()
        {
            Output.AppendLine("Event added");
        }

        public static void EventDeleted(int count)
        {
            if (count == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendLine($"{count} events deleted");
            }
        }

        public static void NoEventsFound()
        {
            Output.AppendLine("No events found");
        }

        public static void PrintEvent(IEvent eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.AppendLine(eventToPrint.ToString());
            }
        }
    }
}
