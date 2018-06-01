using Solid_Examples.StateDoor;
using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Door usa = new Door();
            AbstractState inchisa = new Closed();
            usa.SetState(inchisa);

            Console.ReadLine();
        }
    }
}