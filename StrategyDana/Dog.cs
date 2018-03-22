﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    class Dog: IMove
    {
        string name = "dog";
        IMoveStrategy moveStrategy = new Running4Feet();
        public void Move()
        {
            Console.Write("I'm a {0}", name);
            moveStrategy.Move();
        }
    }
}
