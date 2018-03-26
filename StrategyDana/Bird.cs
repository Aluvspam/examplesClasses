﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    class Bird: FlyEuDana
    {
        string name = "Bird";
        IMoveStrategy moveStrategy = new Flying();
        public void Move()
        {
            Console.Write("I am a {0}", name);
            moveStrategy.Move();
        }

       
    }
}
