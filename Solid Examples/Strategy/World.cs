using System.Collections.Generic;

namespace Solid_Examples.AndreiR
{
    public class World
    {
        Queue<AbstractEntity> coada;
        public World()
        {
            coada = new Queue<AbstractEntity>();
            execute();
        }
        public void execute()
        {
            var b = new Bird();
            var d = new Dog();
            var d2 = new Drone();
            coada.Enqueue(b);
            coada.Enqueue(d);
            coada.Enqueue(d2);
            //object[] things= new object[3] { b, d, d2 };
            //foreach (var thing in things)
            //{
            //    thing.
            //}
            //TO DO: create an abstract class that is implemented by Bird, Dog 
            //and Drone classes and move all common code from these classes in that
            //abstract class. fix the foreach loop above and uncomment it. erase this
            //text after fixing
            b.Move();
            d.Move();
            d2.Move();
        }
        public void OnXeventHandler(int x)
        {
            if (x % 5 == 0)
            {
                coada.Enqueue(new Bird());
            }
            else if (x % 5 == 1)
            {
                coada.Enqueue(new Dog());
            }
            else if (x % 5 == 2)
            {
                coada.Enqueue(new Drone());
            }
            else
            {
                if (coada.Count > 0)
                {
                    var entity = coada.Dequeue();
                    entity.Move();
                }
            }
        }
        private void DequeOnAList()
        {
            var coditza = new List<AbstractEntity>();
            coditza.Add(new Bird());
            coditza.Add(new Dog());
            coditza.Add(new Drone());
            AbstractEntity first;
            first = coditza[0];
            coditza.Remove(coditza[0]);
            AbstractEntity next = coditza[0];
            coditza.Remove(coditza[0]);
        }
    }
}
