﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateDoor
{
    public abstract class AbstractState
    {
        public abstract void goNext(Door door);
    }
}
