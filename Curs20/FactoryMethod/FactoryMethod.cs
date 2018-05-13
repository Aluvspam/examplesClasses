using System;

namespace DoFactory.GangOfFour.Factory.RealWorld
{
    /// <summary>
    /// Factory Method Design Pattern.
    /// </summary>
    public abstract class PizzaStore
    {
        public Pizza OrderPiza() {

            // this is the Factory Method 
            // allows the subclass to choose the concreate object class to instantiate
            var pizza = CreatePizza();
            pizza.Prepare();
            //This is a Template Method
            //acts as a hook for the subclass
            //allows the subclas to define it's implementation 
            Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract Pizza CreatePizza();
        public abstract void Bake();
    }

    public class PizzaOneStore : PizzaStore
    {
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override Pizza CreatePizza()
        {
            return new PizzaOne();
        }
    }

    public class PizzaTwoStore : PizzaStore
    {
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override Pizza CreatePizza()
        {
            return new PizzaTwo();
        }
    }

    public abstract class Pizza
    {
        internal void Bake()
        {
            throw new NotImplementedException();
        }

        internal void Box()
        {
            throw new NotImplementedException();
        }

        internal void Cut()
        {
            throw new NotImplementedException();
        }

        internal void Prepare()
        {
            throw new NotImplementedException();
        }
    }

}