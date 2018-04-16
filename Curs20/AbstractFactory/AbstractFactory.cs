namespace Curs20.AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractWheels CreateWeels();
        public abstract AbstractEngine CreateEngine();
    }
}
