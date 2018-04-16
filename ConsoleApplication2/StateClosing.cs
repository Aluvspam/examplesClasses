using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class StateClosing
    {
        public override void Execute()
        {
            Console.WriteLine("Closing Door.....");
            Thread.Sleep(1000);
        }
        public override void goNext(Door door)
        {
            if (true)
            {
                door.SetState(new Close());
                            }
            else
            {
                door.SetState(new Close());
            }
        }

    }
}
