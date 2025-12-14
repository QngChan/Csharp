using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davutproject17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hava;
            hava = Convert.ToInt32(textBox1.Text);
            if (hava < 10)
            {
                MessageBox.Show("Hava Soğuk");
            }
            if (hava >= 10)
            {
                MessageBox.Show("Hava hafif sıcak");
            }
            if (hava > 25)
            {
                MessageBox.Show("Hava Sıcak");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
