using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDana
{
    public abstract class AbsGame: IGame
    {
        public  AbstractGameMap Map;
        //public printDetails;

        public virtual AbstractGameMap LandEnvironment()
        {
            throw new NotImplementedException();
        }

      
    }
}
