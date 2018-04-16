using Curs20.AbstractFactory;

namespace Curs20.Builder
{
    public class RunExamples
    {
        static CarFactory carMaker;

        public static void Run()
        {
            RunFirstBuilder();
            RunSecondBuilder();
        }

        private static void RunFirstBuilder()
        {
            carMaker = new CarFactory(new PremiumFactory());
            var car = carMaker.MakeCar();

            OptionBuilder builder = new OptionBuilder(car);
            builder.AddXenon();
            builder.AddSpoiler();
            builder.Build();
        }

        private static void RunSecondBuilder()
        {
            carMaker = new CarFactory(new BasicFactory());
            var car = carMaker.MakeCar();

            OptionBuilder2 builder = new OptionBuilder2(car);
            builder.AddXenon()
                .AddSpoiler()
                .AddParkingSensors()
                .Build();
        }
    }
}
