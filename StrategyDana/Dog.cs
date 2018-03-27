using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    class Dog: AbstractFly
    {
        string name = "dog";
        IMoveStrategy moveStrategy = new Running4Feet();

      public Dog()
        {
            SetNewStrategy(new Running4Feet());
        }
        public override string SetName()
        {
            return name;
        }

        public override void Move()
        {
            Console.Write("I'm a {0}", name);
            base.Move();
        }
    }
}
