using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25.Command3
{
    public class RunExample
    {
        public static void Run()
        {
            FlowEngine fe = new FlowEngine();
            fe.AddCommand(()=> {
                Console.WriteLine("1");
            });
            fe.AddCommand(() => {
                Console.WriteLine("2");
                throw new NullReferenceException("For no reason!");
            });
            fe.AddCommand(DoSomething);
            fe.Start();

            fe.AddCommand2(DoSomething2);
        }

        private static void DoSomething2(string s, int i)
        {
            Console.WriteLine(s + i.ToString());
        }

        private static void DoSomething()
        {
            Console.WriteLine("3");
        }
    }
}
