using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateDesign
{
    public class AplicationClassOne : FrameworkClass
    {
        public override void Engine()
        {
            Console.WriteLine("16V");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine(" + Move backwards");
        }
        public override void Send()
        {
            Console.WriteLine("send message");
        }
    }
}
