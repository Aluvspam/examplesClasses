﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solid_Examples
{
    public partial class WriteDanaWinforms : Form
    {
        WriteScreen my = new WriteScreen();
        StringBuilder strTriangle = new StringBuilder();
        public WriteDanaWinforms()
        {
            InitializeComponent();
            my.WriteIt("Peace");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.RoyalBlue;
            WriteForm();
        }
        public void WriteForm()
        {
            int n = 7;
            for (int i = n; i >= 0; i--)
            {
                for (int j = 1; j <= 20; j++)
                    strTriangle.Append('\u2739');
                strTriangle.AppendLine();
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    strTriangle.Append('\u263a');
                strTriangle.AppendLine();
            }
            strTriangle.AppendLine();
        }
        private void lblTriangle_Click(object sender, EventArgs e)
        {
            lblTriangle.Text = strTriangle.ToString();
            //lblTriangles.Text = my.ToString();
        }
    }
}

