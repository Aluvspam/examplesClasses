using Curs20.AbstractFactory;

namespace Curs20.Builder
{
    public class OptionBuilder : AbstractOptionBuilder
    {
        public OptionBuilder(Car car)
        {
            this.car = car;
        }

        public override void AddParkingSensors()
        {
            options.Add(new ParkingSensors());
        }

        public override void AddSpoiler()
        {
            options.Add(new Spoiler());
        }

        public override void AddXenon()
        {
            options.Add(new Xenon());
        }
    }
}
