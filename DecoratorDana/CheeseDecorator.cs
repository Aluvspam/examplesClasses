using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDana
{
    class CheeseDecorator: Decorator
    {
        public CheeseDecorator(PizzaComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cheese";
            this.m_Price = 2.0;
        }
    }
}
