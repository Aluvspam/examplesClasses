using System;

namespace Curs25.Command2
{
    public interface ICommand
    {
        void Execute();
    }

    public class State1 : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Connecting to server");
        }
    }

    public class State2 : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Log in");
        }
    }

    public class State3 : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Get notifications");
        }
    }
    public class State4 : ICommand
    {
        FlowEngine f;
        ICommand stare;
        public State4()
        {
            f = new FlowEngine();
            stare = new State1();
        }
        public void Execute()
        {
            f.AddCommand(stare);
        }
        public void Undo()
        {
            f.RemoveCommand(stare);
        }
    }
}
