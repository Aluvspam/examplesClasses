﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Drone : AbstractEntity
    {
        public Drone()
        {
            name = "Drone";
            moveStrategy = new Flying();
        }
    }
}
