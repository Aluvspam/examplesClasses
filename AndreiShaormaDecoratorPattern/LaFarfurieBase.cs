using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    class LaFarfurieBase: ShaormaComponent
    {
        string name = "Shaorma la farfurie ce contine:";
        double price = 15.5;

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
