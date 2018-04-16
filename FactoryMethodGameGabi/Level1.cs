﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodGameGabi
{
    public class Level1 : IGame
    {
        public void PrintMapDetails()
        {
            throw new NotImplementedException();
        }

        public AbstractGameMap LoadEnvironment()
        {
            return new EmptyMap();
        }
    }
}