namespace Curs17.ChainOfResponsability
{
    public class AbstractHandler
    {
        protected AbstractHandler nextHandler;

        public virtual void Handle(string c)
        {
            if (nextHandler!=null)
            {
                nextHandler.Handle(c);
            }
        }

        public void AddHandler(AbstractHandler h)
        {
            if (nextHandler == null)
            {
                nextHandler = h;
            }
            else
            {
                nextHandler.AddHandler(h);
            }
        }
    }
}