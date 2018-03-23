﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    class Dog
    {
        string name = "dog";
        IMoveStrategy moveStrategy = new Running4Feet();

        public void FlyInRomania()
        {
            Console.WriteLine("I am flying here{0}", name);
        }

        public void Move()
        {
            Console.Write("I'm a {0}", name);
            moveStrategy.Move();
        }
    }
}
