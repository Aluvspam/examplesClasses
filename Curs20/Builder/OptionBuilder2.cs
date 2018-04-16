using Curs20.AbstractFactory;

namespace Curs20.Builder
{
    public class OptionBuilder2 : AbstractOptionBuilder2
    {
        public OptionBuilder2(Car car)
        {
            this.car = car;
        }

        public override AbstractOptionBuilder2 AddParkingSensors()
        {
            car.AddOption(new ParkingSensors());
            return this;
        }

        public override AbstractOptionBuilder2 AddSpoiler()
        {
            car.AddOption(new Spoiler());
            return this;
        }

        public override AbstractOptionBuilder2 AddXenon()
        {
            car.AddOption(new Xenon());
            return this;
        }
    }
}
