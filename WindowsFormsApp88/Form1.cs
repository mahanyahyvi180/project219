﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp88
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] x = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= x.GetUpperBound(0); i++)
            {
                listBox1.Items.Add(x[i]);
            }
        }
    }
}
