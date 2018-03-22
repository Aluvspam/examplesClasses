using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    class Running4Feet : IMoveStrategy
    {
        public void Move()
        {
            Console.WriteLine("I run fast on all my 4 feet");
        }
    }

}
