namespace Curs17.ChainOfResponsability
{
    public class RonHandler : AbstractHandler
    {
        public override void Handle(string c)
        {
            if (c == "RON")
            {
                System.Console.WriteLine("RON");
            }
            base.Handle(c);
        }
    }
}