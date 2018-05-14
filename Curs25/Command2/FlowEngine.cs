using System;
using System.Collections.Generic;

namespace Curs25.Command2
{
    public class FlowEngine
    {
        private List<ICommand> commands;

        public FlowEngine()
        {
            commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void RemoveCommand(ICommand command)
        {
            if (commands.Contains(command))
            {
                commands.Remove(command);
            }
        }

        public void Start()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

    }
}
