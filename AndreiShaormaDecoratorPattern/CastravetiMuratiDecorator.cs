using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    class CastravetiMuratiDecorator : ShaormaDecorator
    {
        public CastravetiMuratiDecorator(ShaormaComponent shaormaComponent) : base(shaormaComponent)
        {
            this.name = "castraveti murati";
            this.price = 2.5;
        }
    }
}
