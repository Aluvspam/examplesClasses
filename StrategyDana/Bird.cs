using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    class Bird
    {
        string name = "Bird";
        IMoveStrategy moveStrategy = new Flying();

        public void FlyInRomania()
        {
            Console.WriteLine("I am flying here{0}", name);
        }

        public void Move()
        {
            Console.Write("I am a {0}", name);
            moveStrategy.Move();
        }

    }
}
