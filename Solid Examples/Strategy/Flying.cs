using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Flying : IMoveStrategy
    {
        public void Move()
        {
            Console.WriteLine(" I fly!");
        }
    }
}
