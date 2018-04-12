using System;

namespace OanaDecorator
{
    public class Run
    {
        public static void Execute()
        {
            PizzaBase pBase = new PizzaBase();
            PrintProductDetails(pBase);

            ExtraCheeseDecorator extraCheese = new ExtraCheeseDecorator(pBase);
            PrintProductDetails(extraCheese);

            GreenOlivesDecorator greenOlives = new GreenOlivesDecorator(pBase);
            PrintProductDetails(greenOlives);

            PepperoniDecorator pepperoni = new PepperoniDecorator(pBase);
            PrintProductDetails(pepperoni);

            HamDecorator ham = new HamDecorator(pBase);
            PrintProductDetails(ham);

            SweetCornDecorator sweetCorn= new SweetCornDecorator(pBase);
            PrintProductDetails(sweetCorn);

            PizzaDough pizzaDough = new PizzaDough();
            PrintProductDetails(pizzaDough);

            PepperoniDecorator pepperoniPizza = new PepperoniDecorator(pizzaDough);
            ExtraCheeseDecorator extraCheesePizza = new ExtraCheeseDecorator(pepperoniPizza);
            GreenOlivesDecorator greenOlivesPizza = new GreenOlivesDecorator(extraCheesePizza);
            PrintProductDetails(greenOlivesPizza);
        }

        private static void PrintProductDetails(PizzaComponent pBase)
        {
            Console.WriteLine("Item: {0} Price: {1}", pBase.GetName(), pBase.GetPrice());
        }
    }

    
}
