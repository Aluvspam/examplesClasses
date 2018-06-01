using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public class ConcreteFactoryBMWCar : FactoryCar
    {
        CarBMW car = new CarBMW();
        public override ICarProduct BuildCar()
        {
            return car;
        }

        public override void ShowCar()
        {
            Console.WriteLine("You have constructed a " + car.Name + " It's a " + car.Weels + " weel car with a: " + car.Engine + " engine and a body shape of: " + car.BodyModel);
        }
    }
}
