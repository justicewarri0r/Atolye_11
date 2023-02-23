using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotOrtalaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int toplam = sayi1 + sayi2 + sayi3;
            label4.Text = toplam.ToString();
            //label4.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int toplam = sayi1 + sayi2 + sayi3;
            int ortalama = toplam / 3;
            label5.Text = ortalama.ToString();
            if (ortalama < 50)
            {
                label5.ForeColor = Color.Firebrick;
            }else if (ortalama >= 50)
            {
                label5.ForeColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
