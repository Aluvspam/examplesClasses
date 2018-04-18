using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFEvent
{
    public partial class Del : Form
    {
        public Del()
        {
            InitializeComponent();
        }
        public delegate void delegateMethod(int n1, int n2);
        public void add(int n1, int n2)
        {
            MessageBox.Show("Ading number: " + n1 + n2.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Del deleg = new Del();
            delegateMethod addNumber = new delegateMethod(deleg.add);
            addNumber(10, 20);

        }
    }
}
