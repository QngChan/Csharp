using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davutproject16
{
    public partial class Form1 : Form
    {
   

       
        private void button1_Click_1(object sender, EventArgs e)
        {
int deger1 = Convert.ToInt32(textBox1.Text);
            int deger2 = Convert.ToInt32(textBox2.Text);
            int sonuc;
            if (comboBox1.Text == "Toplama")
            {
                label4.Text = (deger1 + deger2).ToString();
                
            }
            else if (comboBox1.Text == "Çarpma")

            {
                label4.Text = (deger1 * deger2).ToString();
            }
        }
    }
}
