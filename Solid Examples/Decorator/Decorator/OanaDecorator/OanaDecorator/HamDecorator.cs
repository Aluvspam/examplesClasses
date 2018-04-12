using System;

namespace OanaDecorator
{
    public class HamDecorator : Decorator
    {
        public HamDecorator(PizzaComponent baseComponent) : base(baseComponent)
        {
            this.name = "Ham";
            this.price = 4.0;
        }
    }
}