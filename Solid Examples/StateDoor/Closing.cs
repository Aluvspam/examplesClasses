using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solid_Examples.StateDoor
{
    class Closing : AbstractState
    {
        public override void Execute()
        {
            Console.WriteLine("Closing Door ...");
            Thread.Sleep(1000);
        }
    }
}
