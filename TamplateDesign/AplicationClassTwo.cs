using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateDesign
{
    public class AplicationClassTwo : FrameworkClass
    {
        public override void Engine()
        {
            Console.WriteLine("8v");
        }
        public override void Send()
        {
            Console.WriteLine("Send mail");       
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine(" + move sideways");
        }
    }
}
