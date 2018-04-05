namespace Curs17.ChainOfResponsability
{
    class Exchange
    {
        AbstractHandler handler;

        public void Change(string[] v)
        {
            foreach (var item in v)
            {
                Change(item);
            }
        }

        public void Change(string c)
        {
            handler.Handle(c);
        }

        public void AddHandler(AbstractHandler h)
        {
            if (handler == null)
            {
                handler = h;
            }
            else
            {
                handler.AddHandler(h);
            }
        }
    }
}
