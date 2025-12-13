using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davutproject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cikarma;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            cikarma = sayi1 - sayi2;
            textBox3.Text = cikarma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carpma;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            carpma = sayi1 * sayi2;
            textBox3.Text = carpma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, bolme;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            bolme = sayi1 / sayi2;
            textBox3.Text = bolme.ToString();
        }
    }
}
