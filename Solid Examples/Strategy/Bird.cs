using Solid_Examples.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Bird : Entities
    {
        string name;
        IMoveStrategy moveStrategy = new Flying();
        public void Move()
        {
            Console.Write("I am a {0}", name);
            moveStrategy.Move();
        }

        public override string SetName()
        {
            return name = "Bird";
        }
    }
}
