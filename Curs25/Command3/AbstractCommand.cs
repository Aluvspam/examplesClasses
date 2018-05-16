using System;
using System.Collections.Generic;

namespace Curs25.Command3
{
    public delegate void Command();
    public delegate void Command2(string s, int i);

    class FlowEngine
    {
        private List<Command> commands;
        private List<Command2> commands2;

        public FlowEngine()
        {
            commands = new List<Command>();
            commands2 = new List<Command2>();
        }

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        public void AddCommand2(Command2 command)
        {
            commands2.Add(command);
        }

        public void Start()
        {
            foreach (var command in commands)
            {
                try
                {
                    command();
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var command in commands2)
            {
            }
        }
    }
}
