using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davutproject13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi,sifre;
            kullanici_adi = textBox1.Text;
            sifre = textBox2.Text;
            if (kullanici_adi == "milliegitim @meb.k12.tr")
            {
                MessageBox.Show("Kullanıcı sisteme kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız yanlıştır.");
            }
            if (sifre == "12345")
            {
                MessageBox.Show("Şifre Doğru");
            }
            else
            {
                MessageBox.Show("Şifre Yanlış")
            }
        }
    }
}
