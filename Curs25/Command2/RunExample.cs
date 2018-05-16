using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25.Command2
{
    public class RunExample
    {
        public static void Run()
        {
            FlowEngine a = new FlowEngine();
            a.AddCommand(new State1());
            a.AddCommand(new State2());
            a.Start();
            Console.WriteLine("Urmeaza undoable...");
            a.RemoveCommand(new State1());
            a.Start();

            //ASCII A + B
            int c = 0;
            c = (int)'A' + (int)'B';
            Console.WriteLine(c);
            Console.ReadLine();
            //with undo
            FlowEngine b = new FlowEngine();
            var command = new State4();
            b.AddCommand(command);
            b.Start();
            b.Undo();
            Console.ReadLine();
        }
    }
}
