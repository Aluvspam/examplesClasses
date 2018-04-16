using System.ComponentModel;

namespace Curs17.BuiltInObserverBank
{
    public delegate void MyEventHandler(string s, double n);

    //The Subject
    public class Bank : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event MyEventHandler MyEvent;

        private double euro;

        public double Euro
        {
            get
            {
                if (MyEvent!=null)
                {
                    MyEvent.Invoke("Euro", euro);
                }
                return euro;
            }

            set
            {
                euro = value;
                if (PropertyChanged!=null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Euro"));
                }
            }
        }
    }
}
