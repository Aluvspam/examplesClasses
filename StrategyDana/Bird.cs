using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    class Bird: AbstractFly
    {
        string name = "Bird";
        IMoveStrategy moveStrategy = new Flying();
        public Bird()
        {
            SetNewStrategy(new Flying());
        }
        public override void Move()
        {
            Console.Write("I am a {0}", name);
            base.Move();
        }

        public override string SetName()
        {
            return "bird";
        }
    }
}
