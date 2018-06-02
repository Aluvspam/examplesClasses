using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        Node top;//radacina

        public Tree()//un copac fara nicio valoare
        {
            top = null;
        }
        public Tree(int initial)//un copac cu valoare initiala
        {
            top = new Node(initial);
        }

        public void Add(int value)
        {
            //non recursive
        }
        public void AddRC(int value)
        {
            AddR(ref top, value); //o sa ne zica exact unde trebuie sa adaugam valoarea 
        }
        public void AddR(ref Node N, int value)// si aici se intampla recursivitatea
        {

        }
        public void Print(ref string newString)
        {
            //sa scriem copacul in ordine 
        }
    }
}
