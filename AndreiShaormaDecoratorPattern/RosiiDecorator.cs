using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    class RosiiDecorator : ShaormaDecorator
    {
        public RosiiDecorator(ShaormaComponent shaormaComponent) : base(shaormaComponent)
        {
            this.name = "rosii";
            this.price = 2.00;
        }
    }
}
