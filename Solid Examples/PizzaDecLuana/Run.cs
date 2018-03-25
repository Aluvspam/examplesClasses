using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.PizzaDecLuana
{
	public class Run
	{
		public static void Execute()
		{
			//Basic Pizza
			PizzaBase pBase = new PizzaBase();
			PrintPizza(pBase);
			//Add Olives
			Olives pOlives = new Olives(pBase);
			PrintPizza(pOlives);
			//Add Cheese
			Cheese pCheese = new Cheese(pOlives);
			PrintPizza(pCheese);
			//Add Chilly
			Chilly pChilly = new Chilly(pCheese);
			PrintPizza(pChilly);
			//Add Meat
			Meat pMeat = new Meat(pChilly);
			PrintPizza(pMeat);
			//Add Mushrooms
			Mushrooms pMushrooms = new Mushrooms(pMeat);
			PrintPizza(pMushrooms);


		}

		public static void PrintPizza(BaseLayer pBase)
		{
			Console.WriteLine("Item: {0}, {1}", pBase.GetName(), pBase.GetPrice());
		}
	}
}
