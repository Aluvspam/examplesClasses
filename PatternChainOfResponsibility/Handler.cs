using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChainOfResponsibility
{
    public abstract class Handler
    {//open-close
        protected Handler super;
        protected Handler nextHandler;

        public abstract void HandleRequest();
    }
}
//Tratarea unui eveniment sau a unui obiect se face diferit in funcție de starea acestuia
//•Gestiunea tuturor cazurilor ar implica o structură complexă care să verifice toate cazurile particulare
//•Există legături de dependență între cazurile de utilizare: execuția unui caz poate implica ignorarea celorlalte sau tratarea următorului caz
//Handler
//•clasa abstracta ce definește interfața obiectelor ce gestionează cererea de procesare a evenimentului;
//•HandlerA
//•definește obiecte concrete ce formează secvența de tratare a notificării;
//•Client
//•Generează evenimentul sau notifica primul obiect din secvența de obiecte;


