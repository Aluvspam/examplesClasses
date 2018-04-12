using System;

namespace OanaDecorator
{
    public class GreenOlivesDecorator : Decorator
    {
        public GreenOlivesDecorator(PizzaComponent baseComponent) : base(baseComponent)
        {
            this.name = "Green Olives";
            this.price = 2.0;
        }
    }
}
