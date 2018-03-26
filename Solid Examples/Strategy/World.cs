using Solid_Examples.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class World
    {
        public void execute()
        {
            var b = new Bird();
            var d = new Dog();
            var d2 = new Drone();
            object[] things = new object[3] { b, d, d2 };
            foreach (Entities thing in things)
            {
                thing.Move();
            } 
            //b.Move();
            //d.Move();
            //d2.Move();

        }

    }
}
