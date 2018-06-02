using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        Tree myTree;
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();//generam un nr random
            int num;
            lbArray1.Text = " ";
            lbOrderedList.Text = " ";
            num = rnd.Next(0, 100);
            lbArray1.Text = lbArray1.Text + num.ToString().PadLeft(3);
            myTree = new Tree(num);

            int n = Convert.ToInt32(tbNumber.Text);
            for (int i = 1; i < n; i++)
            {
                num = rnd.Next(0, 100);
                lbArray1.Text = lbArray1.Text + num.ToString().PadLeft(3);
                myTree.AddRC(num);
            }

            string treeString = "";
            myTree.Print(null, ref treeString);
            lbOrderedList.Text = treeString;
        }
    }
}
