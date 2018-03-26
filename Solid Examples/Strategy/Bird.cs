using Solid_Examples.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Bird : AbstractEntities
    {
        public Bird()
        {
            SetNewStrategy(new Flying());
        }
        public override string SetName()
        {
            return "bird";
        }
        public override void Move()
        {
            Console.Write("I'm a {0}", SetName());
            base.Move();
        }
    }
}
