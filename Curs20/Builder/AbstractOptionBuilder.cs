using Curs20.AbstractFactory;
using System.Collections.Generic;

namespace Curs20.Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// First version
    /// </summary>
    public abstract class AbstractOptionBuilder
    {
        protected Car car;
        protected List<Option> options = new List<Option>();

        public abstract void AddSpoiler();
        public abstract void AddXenon();
        public abstract void AddParkingSensors();

        public Car Build()
        {
            foreach (var option in options)
            {
                car.AddOption(option);
            }
            return car;
        }
    }
}
