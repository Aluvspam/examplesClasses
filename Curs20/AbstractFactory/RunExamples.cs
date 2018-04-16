using System;

namespace Curs20.AbstractFactory
{
    /// <summary>
    /// Abstract Factory Design Pattern.
    /// </summary>
    class RunExamples
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Run()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new BasicFactory();
            CarFactory basicCarFactory = new CarFactory(factory1);
            var basicCar = basicCarFactory.MakeCar();

            // Abstract factory #2
            AbstractFactory factory2 = new PremiumFactory();
            CarFactory premiumCarFactory = new CarFactory(factory2);
            var premiumCar = premiumCarFactory.MakeCar();

            // Wait for user input
            Console.ReadLine();
        }
    }
}
