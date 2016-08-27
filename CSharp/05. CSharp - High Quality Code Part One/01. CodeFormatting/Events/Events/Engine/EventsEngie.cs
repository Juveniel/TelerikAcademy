namespace Events.Engine
{
    using System;
    using Events.Contracts;
    
    internal class EventsEngie
    {
        private const string AddCommand = "AddEvent";
        private const string DeleteCommand = "DeleteEvents";
        private const string ListCommand = "ListEvents";
        private const char CommandsSeparator = '|';

        private IEventManager manager;

        public EventsEngie(IEventManager manager)
        {
            this.manager = manager;
        }

        public bool ExecuteNextCommand()
        {
            var command = Console.ReadLine();
            var isValidCommand = true;

            if (command == null)
            {
                return false;
            }

            switch (command[0])
            {
                case 'A':
                    this.AddEvent(command);
                    break;
                case 'D':
                    this.DeleteEvents(command);
                    break;
                case 'L':
                    this.ListEvents(command);
                    break;
                case 'E':
                    isValidCommand = false;
                    break;
                default:                  
                    break;
            }

            return isValidCommand;
        }

        private void ListEvents(string command)
        {
            var pipeIndex = command.IndexOf(CommandsSeparator);
            var date = this.GetDate(command, ListCommand);       
            var count = int.Parse(command.Substring(pipeIndex + 1));

            this.manager.ListEvents(date, count);
        }

        private void DeleteEvents(string command)
        {
            var title = command.Substring(DeleteCommand.Length + 1);
            this.manager.DeleteEvents(title);
        }

        private void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            this.GetParameters(command, AddCommand, out date, out title, out location);        
            this.manager.AddEvent(date, title, location);
        }

        private void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {       
            dateAndTime = this.GetDate(commandForExecution, commandType);        
            var firstPipeIndex = commandForExecution.IndexOf(CommandsSeparator);
            var lastPipeIndex = commandForExecution.LastIndexOf(CommandsSeparator);

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private DateTime GetDate(string command, string commandType)
        {
            var date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));

            return date;
        }
    }
}
