using System;

namespace Curs17.BuiltInObserverBank
{
    class Importer : AbstractClient
    {
        public Importer(Bank bank) : base(bank)
        {
            Bank.PropertyChanged += Bank_PropertyChanged;
        }

        private void Bank_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var eur = Bank.Euro;
             eur = Bank.Euro;
             eur = Bank.Euro;
             eur = Bank.Euro;
            Console.WriteLine("I would like to buy 10000 euros for {0} per euro", eur);
        }
    }
}
