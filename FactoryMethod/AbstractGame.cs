﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class AbstractGame : IGame
    {
        public abstract AbstractGameMap LoadEnviroment();
        AbstractGameMap map;
        void PrintDetails()
        {

        }
    }
}