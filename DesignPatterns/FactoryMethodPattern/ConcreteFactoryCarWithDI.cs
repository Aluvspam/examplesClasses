using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public class ConcreteFactoryCarWithDI : FactoryCar// pentru acest Concrete Factory am folosit si Dependency Injection [DI]
    {
        ICarProduct setCar;
        public ConcreteFactoryCarWithDI(ICarProduct car)
        {
            setCar = car;
        }
        public override ICarProduct BuildCar()
        {
            return setCar;
        }

        public override void ShowCar()
        {
            Console.WriteLine("You have constructed a " + setCar.Name + " It's a " + setCar.Weels + " weel car with a: " + setCar.Engine + " engine and a body shape of: " + setCar.BodyModel);
        }
    }
}
