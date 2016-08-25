﻿namespace Events
{
    using System.Text;

    internal static class Messages
    {
        private static readonly StringBuilder Output = new StringBuilder();

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

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.AppendLine(eventToPrint.ToString());
            }
        }
    }
}
