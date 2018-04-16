using System.Collections.Generic;

namespace Curs20.AbstractFactory
{
    public class Car
    {
        private AbstractWheels wheels;
        private AbstractEngine engine;

        private List<Option> options;

        internal AbstractEngine Engine { get; set; }
        internal AbstractWheels Wheels { get; set; }

        public void AddOption(Option option)
        {
            if (options == null)
            {
                options = new List<Option>();
            }

            options.Add(option);
        }
    }
}
