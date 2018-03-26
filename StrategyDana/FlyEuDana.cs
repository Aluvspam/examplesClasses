using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDana
{
    public abstract class FlyEuDana
    {
        IMoveStrategy moveStrategy = new Flying();
         public void AddMove(Bird Bird)
          
        {
            Bird.AddMove(Bird);
        }

    }
    
}
