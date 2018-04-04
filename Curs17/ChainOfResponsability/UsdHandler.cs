namespace Curs17.ChainOfResponsability
{
    public class UsdHandler : AbstractHandler
    {
        public override void Handle(string c)
        {
            if (c == "USD")
            {
                System.Console.WriteLine("USD");
            }
            base.Handle(c);
        }
    }
}