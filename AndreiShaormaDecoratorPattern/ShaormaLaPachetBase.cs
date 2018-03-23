using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    class ShaormaLaPachetBase: ShaormaComponent
    {
        string name = "Shaorma la pachet";
        double price = 12.5;

        public override string GetName()
        {
            return name;
        }

        public override double GetPrice()
        {
            return price;
        }
    }
}
