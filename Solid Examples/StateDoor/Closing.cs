﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solid_Examples.StateDoor
{
    class Closing : AbstractState
    {
        public override void Execute(Door door)
        {
            Console.WriteLine("Closing Door ...");
            Thread.Sleep(1000);
            goNext(door);
        }

        public override void goNext(Door door)
        {
            if (DateTime.Now.Millisecond % 3 != 0)
            {
                door.SetState(new Closed());
            }
            else
            {
                Console.WriteLine("Picior!!!");
                door.SetState(new Opening());
            }
        }
    }
}
