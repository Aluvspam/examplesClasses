using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree //sursa: https://www.youtube.com/watch?v=5DW5ScDBH-E
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

        public void Add(int value)//pentru adaugarea valorilor copacului, cautam locatia perfecta pentru noul nod pentru ca left < nod && right > nod
        {
            if (top == null)//daca copacul e gol, facem nodul
            {
                Node newNode = new Node(value);
                top = newNode;
                return;//-ul se va opri din a executa altceva dupa ce am facut nodul 
            }
            Node curentNode = top;
            bool added = false;
            do
            {
                //mai jos parcurgem copacul
                if (value < curentNode.value)//du-te in stanga
                {
                    if (curentNode.Left == null)//daca valoarea din stanga e goala, atunci...
                    {
                        //mai jos adaugam
                        Node newNode = new Node(value);
                        curentNode.Left = newNode;
                        added = true;
                    }
                    else
                    {
                        curentNode = curentNode.Left;
                    }
                }
                if (value >= curentNode.value)
                {
                    if (curentNode.Right == null)
                    {
                        Node newNode = new Node(value);
                        curentNode.Right = newNode;
                        added = true;
                    }
                    else
                    {
                        curentNode = curentNode.Right;
                    }

                }
            }
            while (!added);


        }
        public void AddRC(int value)
        {
            AddRecursive(ref top, value); //o sa ne zica exact unde trebuie sa adaugam valoarea 
        }
        public void AddRecursive(ref Node N, int value)//aici avem metoda de adaugare recursiva
        {
            if (N == null)
            {
                Node newNode = new Node(value);
                N = newNode;
                return;

            }
            if(value < N.value)
            {
                AddRecursive(ref N.Left, value);
                return;
            }
            if (value >= N.value)
            {
                AddRecursive(ref N.Right, value);
                return;
            }
        }
        public void Print(Node N, ref string newString)//metoda de printare cu recursivitate 
        {
            if(N == null)
            {
                N = top;
            }
            if (N.Left != null)
            {
                Print(N.Left, ref newString);
                newString = newString + N.value.ToString().PadLeft(3);
            }
            else
            {
                newString = newString + N.value.ToString().PadLeft(3);
            }
            if (N.Right !=null)
            {
                Print(N.Right, ref newString);
            }
        }
    }
}
