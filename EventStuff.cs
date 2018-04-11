using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Class1
{
    delegate void DelegatTratareEveniment(); //declaram un delegate pentru un eveniment
    
    class Eveniment
    {
        
        public event DelegatTratareEveniment activat;//declaram evenimentul
        
        public void Actiune()//metoda apelata la lansarea evenimentului
        {
            if (activat != null)
                //lansam evenimentul
                activat();
        }
    }
    class A
    {
        public void AHandler()
        {
            Console.WriteLine("Eveniment primit de un obiect A");
        }
    }

    class B
    {
        public void BHandler()
        {
            Console.WriteLine("Eveniment primit de un obiect B");
        }
    }
    class Program
    {
       
        static void handler() //rutina de tratare
        {
            Console.WriteLine("Eveniment produs");
        }
        static void Main(string[] args)
        {
           
            Eveniment ev = new Eveniment(); //crearea instantelor
            A a = new A();
            B b = new B();

            //adaugam rutinele de tratare la lisa de evenimente

            ev.activat += new DelegatTratareEveniment(handler);

            ev.activat += new DelegatTratareEveniment(a.AHandler);

            ev.activat += new DelegatTratareEveniment(b.BHandler);

            ev.Actiune();//lansam evenimentul

            ev.activat -= new DelegatTratareEveniment(a.AHandler); //eliminarea unei rutine de tratare
        }
    }
}

//In stransa legatura cu facilitatea delegate a limbajului C#, prezentam evenimentele, events.

//   Cele mai multe evenimente sunt actiuni ale utilizatorilor (click, schimbarea unei liste, introducere de text, sfarsitul unui calcul etc).

//    In.Net, obiectele cunoscute ca si event senders, declanseaza evenimente atunci cand au loc actiuni. Event receivers se ocupa de aceste evenimente prin rularea unei metode numite event handler. Pentru ca event sender-ul nu stie care metoda se va ocupa de eveniment, trebuie creat un delegate care sa se comporte ca un pointer catre event handler.

//   Pentru a produce un eveniment, trebuie sa parcurgem 3 pasi : sa declaram un delegate, sa construim un obiect eveniment, sa apelam delegatul intr-o metoda.



//   Pentru a raspunde la un eveniment, e nevoie de doi pasi: trebuie sa construim o metoda, metoda care trebuie sa se potriveasca signaturii delegatului. Doi, e nevoie sa adauga un event handler care sa indice care metoda trebuie sa primeasca evenimentele.


//   Declararea unui eveniment se face prin folosirea cuvantului cheie event.

//event delegat-eveniment nume-obiect;

//delegat-eveniment – numele delegatului folosit pentru tratarea evenimentului;

//nume-obiect – numele instantei eveniment;

//Exemplu:

//    //declaram un delegate
//    //pentru tratarea evenimentului
//    delegate void DelegatTratareEveniment();
//Deoarece evenimentele au delegati multicast, tipul rezultatului va fi void. Pentru acest exemplu, nu exista parametri, dar evenimentele pot accepta parametri.

//Construim o clasa in care definim o instanta eveniment.

//    class Eveniment
//{
//    //declaram evenimentul
//    public event DelegatTratareEveniment activat;
//    //metoda apelata la lansarea evenimentului
//    public void Actiune()
//    {
//        if (activat != null)
//            //lansam evenimentul
//            activat();
//    }
//}
//Metoda Actiune va fi apelata de program pentru a semnala un eveniment si apeleaza rutina de tratare a evenimentului prin intermediul delegatului activat, daca si numai daca acesta nu este null (verificam faptul ca delegatul nu este null pentru ca este posibil ca metoda Actiune sa fie apelata inainte de inregistrarea rutinei de tratare).

//    In clasa Program a proiectului, construim rutina de tratare numita handler, care in acest exemplu simplu doar va afisa un mesaj.

//    //rutina de tratare
//static void handler()
//{
//    Console.WriteLine("Eveniment produs");
//}
//In metoda Main, construim o instanta a clasei Eveniment, iar metoda handler este inregistrata ca rutina de tratare a evenimentului.

//    //crearea instantei eveniment
//    Eveniment ev = new Eveniment();
////adaugam handler-ul la lista de evenimente
//ev.activat += new DelegatTratareEveniment(handler);
//Lansam evenimentul:

//    //lansam evenimentul
//    ev.Actiune();
//Apelul metodei determina apelul rutine de tratare.

//Multicast

//Multicast in conceptul evenimentelor permite mai multor obiecte sa raspunda la instiintarea aparitiei unui eveniment.

//Exemplu:

//    Scriem acelasi cod pentru declararea unui delegat si pentru declararea clasei Eveniment.

//    Adaugam inca doua clase, a caror rutine de tratare nu sunt statice, deci va trebuie sa creeam instante pentru clasele respective.

//    class A
//{
//    public void AHandler()
//    {
//        Console.WriteLine("Eveniment primit de un obiect A");
//    }
//}

//class B
//{
//    public void BHandler()
//    {
//        Console.WriteLine("Eveniment primit de un obiect B");
//    }
//}
//In clasa Program, adaugam doar in metoda Main:

//    //crearea instantelor
//    A a = new A();
//B b = new B();

////adaugam rutinele de tratare la lisa de evenimente
//ev.activat +=new DelegatTratareEveniment(a.AHandler);
//ev.activat += new DelegatTratareEveniment(b.BHandler);

////lansam evenimentul
//ev.Actiune();
//    //eliminarea unei rutine de tratare
//    ev.activat -= new DelegatTratareEveniment(a.AHandler);
//Ca observatie valabila pentru evenimente in acest exemplu : evenimentele sunt destinate instantelor si nu claselor in general.

//In.Net, mai toate evenimentele sunt implementate folosind delegati multicast, care au doi parametri(unul de tip object – care reprezinta obiectul care provoaca evenimentul, iar celelalt de tip EventArgs care contine data utilizabile in tratarea evenimentului).

//   Putem construi evenimente in interiorul claselor, iar la declansarea lor ne putem da seama unde s-a ajuns cu procesarea codului.

//   Suportul pentru delegate si evenimente permite gestionarea complexitatii programarii pe obiecte intr-un mod mai usor.
//  DELEGATE
//       In programare, exista situatii cand trebuie sa executam o anumita actiune, dar fara sa stim in avans ce metoda sau ce obiect vom apela pentru executarea actiunii.Exemplu : la apasare, un buton va sti ca trebuie sa notifice un anumit obiect, dar nu stie exact care.Solutia simpla consta in conectarea butonului la un delegat si apoi acesta sa indice catre o anumita metoda.


//  Un delegat este un obiect care poate referi o metoda. Chiar daca nu este un obiect, o metoda ocupa un loc in memorie, iar aici, la aceasta adresa, va fi transmis controlul la invocarea metodei.


//  Un delegat reprezinta modul prin care se realizeaza comunicarea intre obiecte.Un delegat este un tip referinta si este este echivalentul unui pointer la functie din C++. Diferenta este ca delegates sunt type-safe si ca sunt orientati pe obiect.

//  Un delegat se declara cu ajutorul cuvantului delegate.

//delegate tip-rez nume (lista-parametri);

//tip-rez – tipul valorii intoarse de metodele pe care delegatul le va apela.

//nume –numele delegatului.

//lista-parametri  – lista de parametri necesari metodelor care vor fi apelate prin intermediul delegatului.

//    Poate fi declarat in afara unei clase, sau in interior.In functie de cum se vrea vizibilitatea lui, ii putem aplica modificatorii de acces public, private, protected,etc.

//   Dupa ce a fost declarat, un delegat poate apela doar metode cu acelasi tip returnat si aceeasi lista de parametri.

//Exemplu :

//    //declararea unui delegat
//    delegate int StringLengthDelegate(string str);
//delegate string StringReverseDelegate(string str);
//Intr-o clasa, construim functiile care vor fi apelate prin delegate.

//    class DelegateTest
//{
//    //returneaza numarul de caractere al unui sir de caractere
//    public int StringLength(string str)
//    {
//        Console.WriteLine("Va returna numarul de caractere");
//        return str.Length;
//    }

//    //returneaza sirul inversat
//    public string StringReverse(string str)
//    {
//        string temp = "";
//        int i;
//        Console.WriteLine("Inverseaza sirul.");
//        //parcurgem sirul invers si concatenam
//        for (i = str.Length - 1; i >= 0; i--)
//            temp += str[i];
//        return temp;
//    }
//}
//In metoda Main :

//    DelegateTest test = new DelegateTest();

////construim delegat
//StringLengthDelegate strLength = new StringLengthDelegate(test.StringLength);
////sirul care va fi transmis functiilor
//string str;
////apelul unei metode prin intermediul delegarii convertim de la numar la string
////pentru ca functia returneaza int
//str = strLength("Test").ToString();
//Console.WriteLine(str);

//    //construim delegat
//    StringReverseDelegate strReverse = new StringReverseDelegate(test.StringReverse);
////apelul unei metode prin intermediul delegarii
//str = strReverse("Test");
//Console.WriteLine(str);
//Pe scurt: avem doua metode statice in clasa DelegateTest ale caror signaturi coincid cu signaturile delegatilor.In Main, construim  referinte de tipul StringLengthDelegate si StringReverseDelegate, pe care le atribuim metodelor.Se mai observa ca invocarea delegatilor determina apelul metodelor.Determinarea metodei apelate se rezolva la momentul executiei, nu la compilare.

//Multicasting

//   Multicasting-ul se defineste ca o facilitate a delegatilor si consta in capacitatea de a crea un lant de metode care vor fi automat apelate la invocarea unui delegat.Delegarile multicast trebuie sa returneze un rezultat de tip void, iar pentru crearea lor se folosesc operatorii += si –=, dupa instantierea unui delegat.


//Exemplu :

//    //declararea unui delegat multicast
//delegate void MulticastDelegat(string str);
////construim delegatii
//MulticastDelegat multiDel;
//MulticastDelegate StringLength = new MulticastDelegat(test.StringLength);
//MulticastDelegat StringReverse = new MulticastDelegat(test.StringReverse);
//multiDel = StringLength;
//    //crearea unui delegat multicast
//    multiDel += StringReverse;
//    Datorita faptului ca la compilare, nu se cunosc metodele care urmeaza a fi executate, lucrul cu delegate este intalnit in arhitecturile care permit adaugarea componentelor pe parcurs.

    //In articolul urmator, se va observa una din utilitatile delegatilor, anume implementarea evenimentelor.
	