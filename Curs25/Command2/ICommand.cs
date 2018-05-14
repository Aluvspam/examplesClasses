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
}
