namespace Events
{
    using System;

    internal class EventEngine
    {
        private static bool ExecuteNextCommand()
        {
            var command = Console.ReadLine();
            var isValidCommand = false;

            if (command == null)
            {
                return false;
            }

            switch (command[0])
            {
                case 'A':
                    AddEvent(command);
                    isValidCommand = true;
                    break;
                case 'D':
                    DeleteEvents(command);
                    isValidCommand = true;
                    break;
                case 'L':
                    ListEvents(command);
                    isValidCommand = true;
                    break;              
                default:
                    isValidCommand = false;
                    break;
            }
           
            return isValidCommand;
        }

        private static void ListEvents(string command)
        {
            var pipeIndex = command.IndexOf('|');
            var date = GetDate(command, "ListEvents");
            var count = int.Parse(command.Substring(pipeIndex));
           
            ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            var title = command.Substring("DeleteEvents".Length + 1);
            
            DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date; string title; string location;
            GetParameters(command, "AddEvent",
                    out date, out title, out location);

            events.AddEvent
                    (date, title, location);
        }
        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');


            int lastPipeIndex = commandForExecution.LastIndexOf('|');
            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle =
    commandForExecution.Substring(firstPipeIndex
    + 1).Trim();
                eventLocation = "";
            }
            else
            {
                eventTitle = commandForExecution.Substring(
                                                        firstPipeIndex + 1,
                                                        lastPipeIndex - firstPipeIndex - 1)
                                                    .Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }
        private
        static
        DateTime
        GetDate(

        string command,
        string commandType
        )
        {
            DateTime date = DateTime.Parse(command
                .Substring(commandType.Length +

                1, 20));
            return date;
        }
    }
}
