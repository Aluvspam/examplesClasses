﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    public class WriteScreen : IWrite
    {
        public void WriteIt(string text)
        {
            Console.WriteLine(text);
        }
    }
}
