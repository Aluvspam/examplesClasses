using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
   public class Drone: AbstractFly
    {
        string name = "Drone";
        IMoveStrategy moveStrategy = new Flying();

       public Drone()
        {
            SetNewStrategy(new Flying()); 
        }
        public override string SetName()
        {
            return name;
        }
        public override void Move()
        {
            Console.Write("I am a {0}", name);
            base.Move();
        }
    }

}

