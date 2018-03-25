using System;

namespace OanaDecorator
{
    public class ExtraCheeseDecorator : Decorator
    {
        public ExtraCheeseDecorator(PizzaComponent baseComponent) : base(baseComponent)
        {
            this.name = "Extra Cheese";
            this.price = 3.0;
        }
    }
}
