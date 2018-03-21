using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Dog : IMove
    {
        public void Move()
        {
            Console.WriteLine("walk on 4 legs");
        }
    }
}
