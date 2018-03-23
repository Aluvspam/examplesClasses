using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    class PuiDecorator : ShaormaDecorator
    {
        public PuiDecorator(ShaormaComponent shaormaComponent) : base(shaormaComponent)
        {
            this.name = " pui "; //de ce e preferabil sa notam in cazul asta parametrii din clasa Decorator protected si nu public cum am trecut eu?
            this.price = 12.00;
        }
    }
}
