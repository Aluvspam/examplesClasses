using System;

namespace OanaDecorator
{
    public class SweetCornDecorator : Decorator
    {
        public SweetCornDecorator(PizzaComponent baseComponent) : base(baseComponent)
        {
            this.name = "Sweet Corn";
            this.price = 2.0;
        }
            
    }
}