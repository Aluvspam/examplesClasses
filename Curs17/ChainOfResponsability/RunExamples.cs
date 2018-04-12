namespace Curs17.ChainOfResponsability
{
    public class RunExamples
    {
        public static void Run()
        {
            Exchange exchange = new Exchange();
            exchange.AddHandler(new RonHandler());
            exchange.AddHandler(new EurHandler());
            exchange.AddHandler(new UsdHandler());
            exchange.Change(new string[] { "RON", "EUR", "RON", "USD", "RON" });
        }
    }
}
