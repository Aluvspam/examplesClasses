using DesignPatterns.FactoryMethodPattern;
using DesignPatterns.StatePatternFeeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryCar newFact = new ConcreteFactoryAudiCar();
            newFact.ShowCar();
            CarBMW BMW = new CarBMW();

            FactoryCar factoryInjection = new ConcreteFactoryCarWithDI(BMW);
            factoryInjection.ShowCar();
            Console.ReadLine();
        }
    }
}
