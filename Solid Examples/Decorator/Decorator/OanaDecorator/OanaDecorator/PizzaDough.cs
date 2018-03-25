using System;

namespace OanaDecorator
{
    public class PizzaDough : PizzaComponent
    {
        private string name = "Pizza Dough";
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