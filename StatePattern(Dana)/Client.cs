using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Dana_
{
    public class Client
    {
        public static void Run()
        {
            Context c = new Context();

        }
    }
}
//Aplicația tratează un anumit eveniment diferit în funcție de starea unui obiect
//•Numărul de stări posibile poate să crească și tratarea unitară a acestora poate să influențeze complexitatea soluției
//•Modul de tratare a acțiunii este asociat unei anumite stări și este încapsulat într-un obiect de stare
//    Handler
//•clasa abstracta ce definește interfața obiectelor ce gestionează cererea de procesare a evenimentului;
//•HandlerA
//•definește obiecte concrete ce formează secvența de tratare a notificării;
//•Client
//•Generează evenimentul sau notifica primul obiect din secvența de obiecte;