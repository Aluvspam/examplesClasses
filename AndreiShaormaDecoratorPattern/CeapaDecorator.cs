using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    class CeapaDecorator : ShaormaDecorator
    {
        public CeapaDecorator(ShaormaComponent shaormaComponent) : base(shaormaComponent)
        {
            this.name = "ceapa";
            this.price = 2.5;
        }
    }
}
