using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.AndreiR
{
    public class AbstractEntity
    {
        protected string name;
        protected IMoveStrategy moveStrategy;
        public virtual void Move()
        {
            Console.Write("I'm a {0}", name);
            moveStrategy.Move();
        }
    }
}
