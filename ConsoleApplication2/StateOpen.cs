using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class StateOpen: IState
    {
        public override void Execute()
        {
            Console.WriteLine("door open, waiting for passanger to go in or out");
            Thread.Sleep(1000);
        }
        public void goNext(Open inContext)
        {

            Door.SetState(new Closing());

        }
    }
}
