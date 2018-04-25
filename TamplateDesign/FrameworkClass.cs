using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateDesign
{
    public abstract class FrameworkClass
    {
        public virtual void TemplateMethod()
        {
            Engine();
            Move();
            Send();
        }
        public virtual void Engine()
        {

        }
        public virtual void Move()
        {
            Console.Write("Move forward");
        }
        public virtual void Send()
        {
           
        }
    }
}
