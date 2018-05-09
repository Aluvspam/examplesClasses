namespace Curs20.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class BasicFactory : AbstractFactory
    {
        public override AbstractWheels CreateWeels()
        {
            return new BasicWheels();
        }

        public override AbstractEngine CreateEngine()
        {
            return new BasicEngine();
        }
    }
}