using System;

namespace Curs20.AbstractFactory
{
    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    abstract class AbstractWheels
    {
    }

    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    abstract class AbstractEngine
    {
        public abstract void Interact(AbstractWheels a);
    }


    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    class BasicWheels : AbstractWheels
    {
    }

    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class BasicEngine : AbstractEngine
    {
        public override void Interact(AbstractWheels a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    class PremiumWheels : AbstractWheels
    {
    }

    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    class PremiumEngine : AbstractEngine
    {
        public override void Interact(AbstractWheels a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
