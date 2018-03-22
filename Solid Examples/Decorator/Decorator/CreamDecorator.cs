using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cream";
            this.m_Price = 1.0;
        }
    }
}
