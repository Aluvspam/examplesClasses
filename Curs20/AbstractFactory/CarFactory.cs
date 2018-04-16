namespace Curs20.AbstractFactory
{
    /// <summary>
    /// The 'Client' class. Interaction environment for the products.
    /// </summary>
    class CarFactory
    {
        private AbstractWheels wheels;
        private AbstractEngine engine;

        // Constructor
        public CarFactory(AbstractFactory factory)
        {
            engine = factory.CreateEngine();
            wheels = factory.CreateWeels();
        }

        public Car MakeCar()
        {
            var car = new Car();
            car.Engine = engine;
            car.Wheels = wheels;
            return car;
        }
    }
}
