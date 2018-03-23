using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDana
{
    class PizzaDough : PizzaComponent
    {
        private string m_Name = "PizzaDough";
        private double m_Price = 200.0;

        public override string GetName()
        {
            return m_Name;
        }
        public override double GetPrice()
        {
            return m_Price;
        }
    }
}
