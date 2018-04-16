using Curs20.AbstractFactory;

namespace Curs20.Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// Second version - recursive version
    /// </summary>
    public abstract class AbstractOptionBuilder2
    {
        protected Car car;

        public abstract AbstractOptionBuilder2 AddSpoiler();
        public abstract AbstractOptionBuilder2 AddXenon();
        public abstract AbstractOptionBuilder2 AddParkingSensors();

        public Car Build()
        {
            return car;
        }
    }
}
