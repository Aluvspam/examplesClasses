using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solid_Examples.StateDoor
{
    public class Open : AbstractState
    {
        public override void Execute(Door door)
        {
            Console.WriteLine("door open, waiting for passengers to go in or out");
            Thread.Sleep(1000);
            goNext(door);
        }

        public override void goNext(Door door)
        {
            door.SetState(new Closing());
        }
    }
}
