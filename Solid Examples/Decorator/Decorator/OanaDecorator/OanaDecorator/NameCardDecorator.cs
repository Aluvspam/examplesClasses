using System;

namespace OanaDecorator
{
    public class NameCardDecorator : Decorator
    {
        private int DiscountRate = 4;

        public NameCardDecorator(PizzaComponent baseComponent) : base(baseComponent)
        {
            this.name = "Nume card";
            this.price = 3.0;
        }

        public override string GetName()
        {
            return base.GetName() + string.Format("\n(Please collect your discount card for {0}%)", DiscountRate);
        }
    }
}
