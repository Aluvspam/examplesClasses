using System;

namespace OanaDecorator
{
    public class PizzaBase : PizzaComponent
    {
        private string name = "Pizza Base";
        private double price = 20.0;

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