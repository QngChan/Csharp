using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace davutproject8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1,alan, bolme;
            sayi1 = Convert.ToDouble(textBox1.Text);
            bolme = sayi1 * sayi1;
            alan = bolme * 3;
            textBox2.Text = alan.ToString();
        }
    }
}
