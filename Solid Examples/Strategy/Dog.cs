using Solid_Examples.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Dog : Entities
    {
        string name;
        IMoveStrategy moveStrategy = new Running4Feet();
        public void Move()
        {
            Console.Write("I'm a {0}", name);
            moveStrategy.Move();
        }
        public override string SetName()
        {
            return name = "dog";
        }
    }
}
