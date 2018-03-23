using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    class VarzaDecorator : ShaormaDecorator
    {
        public VarzaDecorator(ShaormaComponent shaormaComponent) : base(shaormaComponent)
        {
            this.name = "varza";
            this.price = 1.00;
        }
    }
}
