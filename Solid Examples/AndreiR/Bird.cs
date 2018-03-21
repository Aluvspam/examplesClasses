using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
   public class Bird: IMove
    {
        string name = "Bird";
        public void Move()
        {
            Console.WriteLine("I am a {0} and I fly", name);
        }
    }
}
