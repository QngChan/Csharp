using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davutproject10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ortalama;
            ortalama = Convert.ToInt16(textBox1.Text);
            if (ortalama < 85)
            {
                MessageBox.Show("Takdir Alamadın");

            }
            if (ortalama >= 85)
            {
                MessageBox.Show("Takdir Aldın");
            }
        }
    }
}
