using System;
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
            a = int.Parse(txt A.Text);
            b = int.Parse(txt B.Text);
            ketqua = a + b;
            txt ketqua.Text = ketqua.ToString();
        }
    }
}
