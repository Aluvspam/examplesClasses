namespace Curs20.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class PremiumFactory : AbstractFactory
    {
        public override AbstractWheels CreateWeels()
        {
            return new PremiumWheels();
        }

        public override AbstractEngine CreateEngine()
        {
            return new PremiumEngine();
        }
    }
}