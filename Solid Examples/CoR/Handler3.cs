using System;

namespace Solid_Examples.CoR
{
    public class Handler3 : AbstractHandler
    {
        public override void Handle(Request r)
        {
            if (CanHandle(r))
            {
                Console.Write("Fizz");
                r.Handled = true;
            }
            base.Handle(r);
        }
        protected bool CanHandle(Request r)
        {
            return (r.X % 3 == 0);
        }
    }
}
