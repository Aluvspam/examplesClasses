using System;

namespace OanaDecorator
{
    public abstract class Decorator : PizzaComponent
    {
        PizzaComponent pizzaComponent = null;

        protected string name = "Undefined Decorator";
        protected double price = 0.0;

        protected Decorator(PizzaComponent baseComponent)
        {
            pizzaComponent = baseComponent;
        }

        public override string GetName()
        {
            return string.Format("{0}, {1}", pizzaComponent.GetName(), name);
        }

        public override double GetPrice()
        {
            return price + pizzaComponent.GetPrice();
        }
    }
}
