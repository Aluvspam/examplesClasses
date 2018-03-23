using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiShaormaDecoratorPattern
{
    abstract class ShaormaDecorator : ShaormaComponent
    {
        ShaormaComponent ShaormaComponent = null; //ce inseamna asta, e o instanta de clasa abstracta?

        public string name = "Inexistent";
        public double price = 0.0;

        protected ShaormaDecorator(ShaormaComponent shaormaComponent)// care este rolul constructorului?
        {
            ShaormaComponent = shaormaComponent;
        }
        public override double GetPrice()
        {
            return price + ShaormaComponent.GetPrice();
        }
       
        public override string GetName()
        {
            return string.Format("{0} {1},", ShaormaComponent.GetName(), name);
        }
    }
}
