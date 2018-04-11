using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    public class Request
    {
        public int X;
        public bool Handled;
        public Request(int i)
        {
            X = i;
            Handled = false;
        }
    }
}
