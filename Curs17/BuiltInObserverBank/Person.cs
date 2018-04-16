using System;

namespace Curs17.BuiltInObserverBank
{
    class Person : AbstractClient
    {
        public Person(Bank bank) : base(bank)
        {
            Bank.PropertyChanged += Bank_PropertyChanged;
            Bank.MyEvent += Bank_MyEvent;
        }

        private void Bank_MyEvent(string s, double n)
        {
            Console.WriteLine("Somebody used the getter for Bank.Euro");
        }

        //in loc de   public override void Notify()
        private void Bank_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("Thanks, please give me 1000 euros");
            // Bank.Unsubscribe(this);
            Bank.PropertyChanged -= Bank_PropertyChanged;
        }
    }
}
