using DesignPatterns.StatePatternFeeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Human om = new Human();
            AbstractState trist = new SadState();
            om.SetState(trist);
        }
    }
}
