﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    public abstract class ShaormaComponent
    {
        public abstract string GetName();
        public abstract double GetPrice();
    }
}