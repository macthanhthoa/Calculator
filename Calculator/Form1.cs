﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cong_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketqua = a + b;
            txtketqua.Text = ketqua.ToString();
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a - b;
            txtketqua.Text = c.ToString();
        }
    }
}
