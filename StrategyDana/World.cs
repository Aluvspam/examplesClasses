using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    public class World: FlyEuDana
    {
        public void execute()
        {
            var b = new Bird();
            var d = new Dog();
            var d2 = new Drone();
            object[] things = new object[3] { b, d, d2 };
            foreach (var thing in things)
            {
                //thing.
            }
            //TO DO: create an abstract class that is implemented by Bird, Dog 
            //and Drone classes and move all common code from these classes in that
            //abstract class. fix the foreach loop above and uncomment it. erase this
            //text after fixing
           
        b.Move();
            d.Move();
            d2.Move();
        }


    }
}
