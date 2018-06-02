using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int value;
        public Node Left;
        public Node Right;

        public Node(int initial)
        {
            value = initial;
            //cand creezi un obiect nou in copac, left si right nu sunt conectati deci sunt null
            Left = null;
            Right = null;
        }
    }
}
