using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid_Examples
{
    public class dogDaniel : IMove
    {
        string name = "dog";
        public void Move()
        {
            Console.WriteLine("I walk on 4 legs", name); 
        }
    }
}