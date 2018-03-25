using System;

namespace OanaDecorator
{
    public class PepperoniDecorator : Decorator
    {
        public PepperoniDecorator(PizzaComponent baseComponent) : base(baseComponent)
        {
            this.name = "Pepperoni";
            this.price = 4.0;
        }
    }
}