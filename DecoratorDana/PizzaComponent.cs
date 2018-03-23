using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDana
{
    public abstract class PizzaComponent
    {
        public abstract  string GetName();
        public abstract  double GetPrice();
    }
}
