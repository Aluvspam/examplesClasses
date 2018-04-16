using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodGameGabi
{
    public interface Level1 : IGame
    {
         LoadEnvironment(Product);
    }
}
