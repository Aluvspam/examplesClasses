using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDana
{
    public class Run
    {
        public static void Execute()

        {
            PizzaDough aDough = new PizzaDough();
            PrintProductDetails(aDough);
            CheeseDecorator cheesePizza = new CheeseDecorator(aDough);
            PrintProductDetails(cheesePizza);
            HawayDecorator hawai = new HawayDecorator(aDough);
            PrintProductDetails(hawai);
            NameCardDecorator nameCardOnCake = new NameCardDecorator(cheesePizza);
            PrintProductDetails(nameCardOnCake);
        }
        private static void PrintProductDetails(PizzaComponent aDough)
        {
            Console.WriteLine("Item: {0} Price: {1}", aDough.GetName(), aDough.GetPrice()); ;
        }
       
    }
}
