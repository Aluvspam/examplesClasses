using Solid_Examples.AndreiR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.Strategy
{
    public abstract class AbstractEntities
    {
        private IMoveStrategy moveStrategy;
        public virtual void Move()
        {
            moveStrategy.Move();
        }
        public abstract string SetName();
        public virtual void SetNewStrategy(IMoveStrategy newStrategy)
        {
            moveStrategy = newStrategy;
        }
    }
}
