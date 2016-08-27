namespace Events
{
    using System;
    using Events.Engine;
    using Events.Models;
    using Events.Utils;

    public class Startup
    {
        public static void Main()
        {
            var events = new EventManager();       
            var engine = new EventsEngie(events);

            var hasNextCommand = engine.ExecuteNextCommand();
            while (hasNextCommand)
            {
                hasNextCommand = engine.ExecuteNextCommand();
            }

            Console.WriteLine(MessageLogger.PrintOutput());
        }
    }
}
