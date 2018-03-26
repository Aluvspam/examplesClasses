using Solid_Examples.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class Dog : AbstractEntities
    {
        public Dog()
        {
            SetNewStrategy(new Running4Feet());
        }
        public override string SetName()
        {
            return "dog";
        }
        public override void Move()
        {
            Console.Write("I'm a {0}", SetName());
            base.Move();
        }
    }
}
