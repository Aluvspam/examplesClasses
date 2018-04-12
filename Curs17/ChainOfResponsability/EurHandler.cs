namespace Curs17.ChainOfResponsability
{
    public class EurHandler : AbstractHandler
    {
        public override void Handle(string c)
        {
            if (c == "EUR")
            {
                System.Console.WriteLine("EUR");
            }
            base.Handle(c);
        }
    }
}