using System.Collections.Generic;

namespace Curs17.BankExample
{
    class Bank
    {
        private List<AbstractClient> clients = new List<AbstractClient>();

        private double eur;

        public double Euro
        {
            get { return eur; }
            set
            {
                eur = value;
                if (clients!=null && clients.Count > 0)
                {
                    for (int i = clients.Count - 1; i >= 0; i--)
                    {
                        clients[i].Notify();
                    }
                }
            }
        }

        public void Subscribe(AbstractClient client)
        {
            clients.Add(client);
        }

        public void Unsubscribe(AbstractClient client)
        {
            if (clients.Contains(client))
            {
                clients.Remove(client);
            }
        }
    }
}
