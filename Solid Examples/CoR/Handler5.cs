using System;

namespace Solid_Examples.CoR
{
    public class Handler5 : AbstractHandler
    {
        public override void Handle(Request r)
        {
            if (CanHandle(r))
            {
                Console.Write("Buzz");
                r.Handled = true;
            }
            base.Handle(r);
        }
        protected bool CanHandle(Request r)
        {
            return (r.X % 5 == 0);
        }
    }
}
