using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    class VitaDecorator : ShaormaDecorator
    {
        public VitaDecorator(ShaormaComponent shaormaComponent) : base(shaormaComponent)
        {
            this.name = "vita";
            this.price = 5.00;
        }
    }
}
