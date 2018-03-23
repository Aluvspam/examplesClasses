using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDana
{
    class NameCardDecorator: Decorator
    {
        private int m_DiscountRate = 5;
        public NameCardDecorator(PizzaComponent baseComponent)
            : base (baseComponent)
        {
            this.m_Name = "Nume Card";
            this.m_Price = 4.0;
        }
        public override string GetName()
        {
            return base.GetName() +
                string.Format("\n(Please Collect your discount card for {0}%)",
                m_DiscountRate);
        }
    }
}
