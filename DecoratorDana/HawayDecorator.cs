using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDana
{
    class HawayDecorator : Decorator
    {
        public HawayDecorator (PizzaComponent baseComponent)
    : base(baseComponent)
    {
            this.m_Name = "Pineapple and ham";
            this.m_Price = 4.0;
        }
    }
}